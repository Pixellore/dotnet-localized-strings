﻿using System;

namespace Rotorz.Games.Localization.Internal.NGettext.Plural
{
	/// <summary>
	/// Represents a plural rule evaluation delegate used in the DefaultPluralRule.
	/// </summary>
	/// <param name="number">Number whitch needs to be evaluated.</param>
	/// <returns>Plural form index.</returns>
	public delegate int PluralRuleEvaluatorDelegate(long number);
}