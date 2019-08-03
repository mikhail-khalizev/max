using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8ad5656e-052e-4936-be5e-a8cc48eb6c59")]
        public void Method_100d_67d8()
        {
            ii(0x100d_67d8, 5); pushd(0x330);                           /* push 0x330 */
            ii(0x100d_67dd, 5); calld(Definitions.sys_check_available_stack_size, 0x8f570); /* call 0x10165d52 */
            ii(0x100d_67e2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_67e3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_67e4, 1); pushd(esi);                             /* push esi */
            ii(0x100d_67e5, 1); pushd(edi);                             /* push edi */
            ii(0x100d_67e6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_67e7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_67e9, 6); sub(esp, 0x318);                        /* sub esp, 0x318 */
            ii(0x100d_67ef, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_67f2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_67f5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_67f8, 7); mov(memd_a32[ds, edx + 0x13], 0x101b_5f98); /* mov dword [edx+0x13], 0x101b5f98 */
            ii(0x100d_67ff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6802, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x100d_6808, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_680b, 7); mov(memd_a32[ds, edx + 0xc], 0);        /* mov dword [edx+0xc], 0x0 */
            ii(0x100d_6812, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_6815, 4); mov(memb_a32[ds, edx + 0x12], 0);       /* mov byte [edx+0x12], 0x0 */
            ii(0x100d_6819, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_681c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_681f, 4); mov(memw_a32[ds, edx + 0x10], ax);      /* mov [edx+0x10], ax */
            ii(0x100d_6823, 6); lea(edx, ebp - 0x314);                  /* lea edx, [ebp-0x314] */
            ii(0x100d_6829, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_682d, 5); calld(0x1013_45c2, 0x5dd90);            /* call 0x101345c2 */
            ii(0x100d_6832, 7); movsx(edx, memw_a32[ss, ebp - 0x310]);  /* movsx edx, word [ebp-0x310] */
            ii(0x100d_6839, 5); mov(eax, 0x280);                        /* mov eax, 0x280 */
            ii(0x100d_683e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_6840, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_6842, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_6844, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_6847, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_6849, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100d_684b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_684e, 4); mov(memw_a32[ds, edx + 0x4], ax);       /* mov [edx+0x4], ax */
            ii(0x100d_6852, 7); movsx(edx, memw_a32[ss, ebp - 0x30e]);  /* movsx edx, word [ebp-0x30e] */
            ii(0x100d_6859, 5); mov(eax, 0x1e0);                        /* mov eax, 0x1e0 */
            ii(0x100d_685e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_6860, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_6862, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_6864, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_6867, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_6869, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100d_686b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_686e, 4); mov(memw_a32[ds, edx + 0x6], ax);       /* mov [edx+0x6], ax */
            ii(0x100d_6872, 6); mov(eax, memd_a32[ss, ebp - 0x310]);    /* mov eax, [ebp-0x310] */
            ii(0x100d_6878, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_687b, 4); mov(memw_a32[ds, edx + 0x8], ax);       /* mov [edx+0x8], ax */
            ii(0x100d_687f, 6); mov(eax, memd_a32[ss, ebp - 0x30e]);    /* mov eax, [ebp-0x30e] */
            ii(0x100d_6885, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_6888, 4); mov(memw_a32[ds, edx + 0xa], ax);       /* mov [edx+0xa], ax */
            ii(0x100d_688c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_688f, 6); mov(memd_a32[ss, ebp - 0x318], eax);    /* mov [ebp-0x318], eax */
            ii(0x100d_6895, 6); mov(eax, memd_a32[ss, ebp - 0x318]);    /* mov eax, [ebp-0x318] */
            ii(0x100d_689b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_689d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_689e, 1); popd(edi);                              /* pop edi */
            ii(0x100d_689f, 1); popd(esi);                              /* pop esi */
            ii(0x100d_68a0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_68a1, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_68a2, 1); retd(); return;                         /* ret */
        }
    }
}
