using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_768a-6d110641")]
        public void Method_1014_768a()
        {
            ii(0x1014_768a, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_768f, 5); call(Definitions.sys_check_available_stack_size, 0x1_e6be); /* call 0x10165d52 */
            ii(0x1014_7694, 1); push(ecx);                              /* push ecx */
            ii(0x1014_7695, 1); push(esi);                              /* push esi */
            ii(0x1014_7696, 1); push(edi);                              /* push edi */
            ii(0x1014_7697, 1); push(ebp);                              /* push ebp */
            ii(0x1014_7698, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_769a, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_76a0, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_76a3, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1014_76a6, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1014_76a9, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_76ac, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_76af, 5); call(0x1014_73de, -0x2d6);              /* call 0x101473de */
            ii(0x1014_76b4, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_76b7, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_76ba, 5); call(0x1013_c1ce, -0xb4f1);             /* call 0x1013c1ce */
            ii(0x1014_76bf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_76c2, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_76c5, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_76c8, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1014_76cb, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1014_76ce, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_76d1, 3); call_abs(memd[ds, ebx + 20]);           /* call dword [ebx+0x14] */
            ii(0x1014_76d4, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_76d7, 5); call(0x1014_7446, -0x296);              /* call 0x10147446 */
            ii(0x1014_76dc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_76de, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_76df, 1); pop(edi);                               /* pop edi */
            ii(0x1014_76e0, 1); pop(esi);                               /* pop esi */
            ii(0x1014_76e1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_76e2, 1); ret();                                  /* ret */
        }
    }
}
