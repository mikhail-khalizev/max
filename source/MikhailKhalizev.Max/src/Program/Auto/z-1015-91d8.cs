using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_91d8-a5834e45")]
        public void Method_1015_91d8()
        {
            ii(0x1015_91d8, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_91dd, 5); call(Definitions.sys_check_available_stack_size, 0xcb70); /* call 0x10165d52 */
            ii(0x1015_91e2, 1); push(ebx);                              /* push ebx */
            ii(0x1015_91e3, 1); push(ecx);                              /* push ecx */
            ii(0x1015_91e4, 1); push(esi);                              /* push esi */
            ii(0x1015_91e5, 1); push(edi);                              /* push edi */
            ii(0x1015_91e6, 1); push(ebp);                              /* push ebp */
            ii(0x1015_91e7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_91e9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_91ef, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_91f2, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_91f5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_91f8, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1015_91fb, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1015_9200, 5); call(0x100f_448c, -0x6_4d79);           /* call 0x100f448c */
            ii(0x1015_9205, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1015_9208, 4); cmp(memb[ds, eax + 87], 4);             /* cmp byte [eax+0x57], 0x4 */
            ii(0x1015_920c, 2); if(jnz(0x1015_9217, 9)) goto l_0x1015_9217; /* jnz 0x10159217 */
            ii(0x1015_920e, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1015_9211, 4); mov(memb[ds, eax + 87], 0);             /* mov byte [eax+0x57], 0x0 */
            ii(0x1015_9215, 2); jmp(0x1015_921e, 7); goto l_0x1015_921e; /* jmp 0x1015921e */
        l_0x1015_9217:
            ii(0x1015_9217, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1015_921a, 4); mov(memb[ds, eax + 87], 4);             /* mov byte [eax+0x57], 0x4 */
        l_0x1015_921e:
            ii(0x1015_921e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_9220, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_9221, 1); pop(edi);                               /* pop edi */
            ii(0x1015_9222, 1); pop(esi);                               /* pop esi */
            ii(0x1015_9223, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_9224, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_9225, 1); ret();                                  /* ret */
        }
    }
}
