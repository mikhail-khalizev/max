using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_7e01-c83db2d7")]
        public void Method_100d_7e01()
        {
            ii(0x100d_7e01, 5); push(0x38);                             /* push 0x38 */
            ii(0x100d_7e06, 5); call(Definitions.sys_check_available_stack_size, 0x8_df47); /* call 0x10165d52 */
            ii(0x100d_7e0b, 1); push(ebx);                              /* push ebx */
            ii(0x100d_7e0c, 1); push(ecx);                              /* push ecx */
            ii(0x100d_7e0d, 1); push(esi);                              /* push esi */
            ii(0x100d_7e0e, 1); push(edi);                              /* push edi */
            ii(0x100d_7e0f, 1); push(ebp);                              /* push ebp */
            ii(0x100d_7e10, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_7e12, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100d_7e18, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_7e1b, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_7e1e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_7e21, 5); call(0x100d_811c, 0x2f6);               /* call 0x100d811c */
            ii(0x100d_7e26, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_7e29, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_7e2c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7e2f, 1); push(eax);                              /* push eax */
            ii(0x100d_7e30, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_7e33, 2); push(memd[ds, eax]);                    /* push dword [eax] */
            ii(0x100d_7e35, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7e38, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_7e3b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7e3e, 1); push(eax);                              /* push eax */
            ii(0x100d_7e3f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7e42, 3); mov(edx, memd[ds, eax + 8]);            /* mov edx, [eax+0x8] */
            ii(0x100d_7e45, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_7e48, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_7e4b, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100d_7e4e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7e51, 5); call(Definitions.my_min, -0x4_e6d2);    /* call 0x10089784 */
            ii(0x100d_7e56, 1); push(eax);                              /* push eax */
            ii(0x100d_7e57, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7e5a, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x100d_7e5d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_7e60, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_7e63, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_7e66, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7e69, 5); call(Definitions.my_min, -0x4_e6ea);    /* call 0x10089784 */
            ii(0x100d_7e6e, 1); push(eax);                              /* push eax */
            ii(0x100d_7e6f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_7e72, 5); call(0x100d_4e8c, -0x2feb);             /* call 0x100d4e8c */
            ii(0x100d_7e77, 1); push(eax);                              /* push eax */
            ii(0x100d_7e78, 5); call(/* sys */ 0x1016_abbc, 0x9_2d3f);  /* call 0x1016abbc */
            ii(0x100d_7e7d, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100d_7e80, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_7e82, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_7e83, 1); pop(edi);                               /* pop edi */
            ii(0x100d_7e84, 1); pop(esi);                               /* pop esi */
            ii(0x100d_7e85, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_7e86, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_7e87, 1); ret();                                  /* ret */
        }
    }
}
