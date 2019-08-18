using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_9f69-205d5e9e")]
        public void Method_100e_9f69()
        {
            ii(0x100e_9f69, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_9f6e, 5); calld(Definitions.sys_check_available_stack_size, 0x7_bddf); /* call 0x10165d52 */
            ii(0x100e_9f73, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_9f74, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_9f75, 1); pushd(esi);                             /* push esi */
            ii(0x100e_9f76, 1); pushd(edi);                             /* push edi */
            ii(0x100e_9f77, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_9f78, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_9f7a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_9f80, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_9f83, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100e_9f86, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_9f8a, 3); lea(eax, eax + eax * 2);                /* lea eax, [eax+eax*2] */
            ii(0x100e_9f8d, 6); mov(edx, memd_a32[ds, 0x101c_3660]);    /* mov edx, [0x101c3660] */
            ii(0x100e_9f93, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_9f95, 3); movsx(eax, memb_a32[ds, eax]);          /* movsx eax, byte [eax] */
            ii(0x100e_9f98, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100e_9f9a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_9f9c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9f9f, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x100e_9fa1, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_9fa5, 3); lea(eax, eax + eax * 2);                /* lea eax, [eax+eax*2] */
            ii(0x100e_9fa8, 6); mov(edx, memd_a32[ds, 0x101c_3660]);    /* mov edx, [0x101c3660] */
            ii(0x100e_9fae, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_9fb0, 4); movsx(eax, memb_a32[ds, eax + 0x1]);    /* movsx eax, byte [eax+0x1] */
            ii(0x100e_9fb4, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100e_9fb6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_9fb8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9fbb, 3); mov(memb_a32[ds, eax + 0x1], dl);       /* mov [eax+0x1], dl */
            ii(0x100e_9fbe, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_9fc2, 3); lea(eax, eax + eax * 2);                /* lea eax, [eax+eax*2] */
            ii(0x100e_9fc5, 6); mov(edx, memd_a32[ds, 0x101c_3660]);    /* mov edx, [0x101c3660] */
            ii(0x100e_9fcb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_9fcd, 4); movsx(eax, memb_a32[ds, eax + 0x2]);    /* movsx eax, byte [eax+0x2] */
            ii(0x100e_9fd1, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100e_9fd3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_9fd5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9fd8, 3); mov(memb_a32[ds, eax + 0x2], dl);       /* mov [eax+0x2], dl */
            ii(0x100e_9fdb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_9fdd, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_9fde, 1); popd(edi);                              /* pop edi */
            ii(0x100e_9fdf, 1); popd(esi);                              /* pop esi */
            ii(0x100e_9fe0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_9fe1, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_9fe2, 1); retd(); return;                         /* ret */
        }
    }
}
