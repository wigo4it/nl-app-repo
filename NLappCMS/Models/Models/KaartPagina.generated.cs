//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace NLappCMS.Models
{
	/// <summary>KaartPagina</summary>
	[PublishedContentModel("kaartPagina")]
	public partial class KaartPagina : PublishedContentModel, ISeoBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "kaartPagina";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public KaartPagina(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<KaartPagina, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Kaarten
		///</summary>
		[ImplementPropertyType("mapLinks")]
		public object MapLinks
		{
			get { return this.GetPropertyValue("mapLinks"); }
		}

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[ImplementPropertyType("seoMetaDescription")]
		public Our.Umbraco.Vorto.Models.VortoValue SeoMetaDescription
		{
			get { return NLappCMS.Models.SeoBase.GetSeoMetaDescription(this); }
		}
	}
}