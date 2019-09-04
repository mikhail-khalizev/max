using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_77f0-d3ac5b67")]
        public void Method_1014_77f0()
        {
            ii(0x1014_77f0, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_77f5, 5); call(Definitions.sys_check_available_stack_size, 0x1_e558); /* call 0x10165d52 */
            ii(0x1014_77fa, 1); push(ebx);                              /* push ebx */
            ii(0x1014_77fb, 1); push(ecx);                              /* push ecx */
            ii(0x1014_77fc, 1); push(esi);                              /* push esi */
            ii(0x1014_77fd, 1); push(edi);                              /* push edi */
            ii(0x1014_77fe, 1); push(ebp);                              /* push ebp */
            ii(0x1014_77ff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7801, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_7807, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_780a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_780d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_7810, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_7813, 5); call(Definitions.my_string_ctor_string, -0x5d72); /* call 0x10141aa6 */
            ii(0x1014_7818, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_781b, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1014_781e, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_7821, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_7824, 3); mov(edx, memd[ds, eax + 4]);            /* mov edx, [eax+0x4] */
            ii(0x1014_7827, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_782a, 3); mov(memd[ds, eax + 4], edx);            /* mov [eax+0x4], edx */
            ii(0x1014_782d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_7830, 4); mov(dx, memw[ds, eax + 8]);             /* mov dx, [eax+0x8] */
            ii(0x1014_7834, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_7837, 4); mov(memw[ds, eax + 8], dx);             /* mov [eax+0x8], dx */
            ii(0x1014_783b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_783e, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_7841, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_7844, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7846, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_7847, 1); pop(edi);                               /* pop edi */
            ii(0x1014_7848, 1); pop(esi);                               /* pop esi */
            ii(0x1014_7849, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_784a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_784b, 1); ret();                                  /* ret */
        }
    }
}
