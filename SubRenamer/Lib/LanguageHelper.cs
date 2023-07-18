using System.Windows.Forms;
using System;
using System.ComponentModel;
using SubRenamer;

public class LanguageHelper
{
    readonly MainForm _mainForm;
    readonly SettingForm _settingForm;
    public LanguageHelper(MainForm mainForm, SettingForm settingForm)
    {
        _mainForm = mainForm;
        _settingForm = settingForm;
    }


    #region SetAllLang  
    /// <summary>  
    /// Set language  
    /// </summary>  
    /// <param name="lang">language:zh-CN, en-US</param>  
    public void SetAllLang(string lang)
    {
        System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
        SetLang(lang, _settingForm, typeof(SettingForm));
        SetLang(lang, _mainForm, typeof(MainForm));
        _mainForm.RefreshFileListUi();
    }
    #endregion

    #region SetLang  
    /// <summary>  
    ///   
    /// </summary>  
    /// <param name="lang">language:zh-CN, en-US</param>  
    /// <param name="form">the form you need to set</param>  
    /// <param name="formType">the type of the form </param>  
    private void SetLang(string lang, Form form, Type formType)
    {
        if (form != null)
        {
            ComponentResourceManager resources = new ComponentResourceManager(formType);
            resources.ApplyResources(form, "$this");
            AppLang(form, resources);
        }
    }
    #endregion

    #region AppLang for control  
    /// <summary>  
    ///  loop set the propery of the control  
    /// </summary>  
    /// <param name="control"></param>  
    /// <param name="resources"></param>  
    private void AppLang(Control control, ComponentResourceManager resources)
    {
        if (control is Form)
        {
            var form = (Form)control;
            var m = form.Menu;
            if (m != null && m.MenuItems.Count > 0)
            {
                foreach (MenuItem c in m.MenuItems)
                {
                    AppLang(c, resources);
                }
            }
        }


        if (control is ComboBox)
        {
            var combo = (ComboBox)control;
            var count = combo.Items.Count;
            combo.Items.Clear();
            combo.BeginUpdate();
            for (int i = 0; i < count; i++)
            {
                var number = i == 0 ? "" : $"{i}";
                var item = resources.GetString($"{control.Name}.Items{number}");
                combo.Items.Add(item);
            }
            combo.EndUpdate();
        }
        else if (control is ListView)
        {
            var listView = (ListView)control;
            foreach (ColumnHeader c in listView.Columns)
            {
                if (c.Tag != null)
                {
                    resources.ApplyResources(c, c.Tag.ToString());
                }
            }
        }
        else
        {
            if (!(control is Panel))
                resources.ApplyResources(control, control.Name);
            foreach (Control c in control.Controls)
            {
                resources.ApplyResources(c, c.Name);
                AppLang(c, resources);
            }
        }
    }
    #endregion

    #region AppLang for menuitem  
    /// <summary>  
    /// set the toolscript   
    /// </summary>  
    /// <param name="menuItem"></param>  
    /// <param name="resources"></param>  
    private void AppLang(MenuItem menuItem, ComponentResourceManager resources)
    {
        if (menuItem.Tag != null)
        {
            resources.ApplyResources(menuItem, menuItem.Tag.ToString());
            if (menuItem.MenuItems.Count > 0)
            {
                foreach (MenuItem c in menuItem.MenuItems)
                {
                    AppLang(c, resources);
                }
            }
        }
    }

    #endregion

}
