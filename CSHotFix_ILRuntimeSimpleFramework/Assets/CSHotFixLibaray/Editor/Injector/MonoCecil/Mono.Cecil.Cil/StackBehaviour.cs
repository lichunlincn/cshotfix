using System;
namespace Editor_Mono.Cecil.Cil
{
	public enum StackBehaviour
	{
		Pop0,
		Pop1,
		Pop1_pop1,
		Popi,
		Popi_pop1,
		Popi_popi,
		Popi_popi8,
		Popi_popi_popi,
		Popi_popr4,
		Popi_popr8,
		Popref,
		Popref_pop1,
		Popref_popi,
		Popref_popi_popi,
		Popref_popi_popi8,
		Popref_popi_popr4,
		Popref_popi_popr8,
		Popref_popi_popref,
		PopAll,
		Push0,
		Push1,
		Push1_push1,
		Pushi,
		Pushi8,
		Pushr4,
		Pushr8,
		Pushref,
		Varpop,
		Varpush
	}
}
