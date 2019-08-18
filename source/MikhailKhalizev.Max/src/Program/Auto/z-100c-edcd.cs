using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("26521679-93f7-413b-a062-a52ea80fde9c")]
        public void Method_100c_edcd()
        {
            ii(0x100c_edcd, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x100c_edd2, 5); calld(Definitions.sys_check_available_stack_size, 0x9_6f7b); /* call 0x10165d52 */
            ii(0x100c_edd7, 1); pushd(esi);                             /* push esi */
            ii(0x100c_edd8, 1); pushd(edi);                             /* push edi */
            ii(0x100c_edd9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_edda, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_eddc, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x100c_ede2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_ede5, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100c_ede8, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100c_edeb, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100c_edee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_edf1, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100c_edf5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_edf8, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x100c_edfb, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_edfe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_ee01, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x100c_ee05, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_ee08, 4); sub(ax, memw_a32[ds, edx + 0x4]);       /* sub ax, [edx+0x4] */
            ii(0x100c_ee0c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_ee0f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ee12, 5); calld(0x100c_e71f, -0x6f8);             /* call 0x100ce71f */
            ii(0x100c_ee17, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ee1a, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100c_ee1d, 5); calld(0x100d_4e8c, 0x606a);             /* call 0x100d4e8c */
            ii(0x100c_ee22, 3); mov(memd_a32[ss, ebp - 0x2a], eax);     /* mov [ebp-0x2a], eax */
            ii(0x100c_ee25, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ee28, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100c_ee2b, 5); calld(0x100d_4f58, 0x6128);             /* call 0x100d4f58 */
            ii(0x100c_ee30, 4); mov(memw_a32[ss, ebp - 0x30], ax);      /* mov [ebp-0x30], ax */
            ii(0x100c_ee34, 6); calld_abs(memd_a32[ds, 0x101b_ddf0]);   /* call dword [0x101bddf0] */
            ii(0x100c_ee3a, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100c_ee3e, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100c_ee40, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_ee42, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_ee45, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_ee47, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100c_ee49, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_ee4c, 3); add(eax, memd_a32[ds, edx + 0x4]);      /* add eax, [edx+0x4] */
            ii(0x100c_ee4f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_ee52, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_ee55, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100c_ee58, 5); calld(0x100d_4d78, 0x5f1b);             /* call 0x100d4d78 */
            ii(0x100c_ee5d, 1); pushd(eax);                             /* push eax */
            ii(0x100c_ee5e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_ee63, 1); pushd(eax);                             /* push eax */
            ii(0x100c_ee64, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_ee68, 1); pushd(eax);                             /* push eax */
            ii(0x100c_ee69, 4); movsx(ecx, memw_a32[ss, ebp - 0x14]);   /* movsx ecx, word [ebp-0x14] */
            ii(0x100c_ee6d, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100c_ee70, 3); movsx(ebx, memw_a32[ds, ebx]);          /* movsx ebx, word [ebx] */
            ii(0x100c_ee73, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_ee76, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100c_ee79, 5); calld(0x100e_a99a, 0x1_bb1c);           /* call 0x100ea99a */
            ii(0x100c_ee7e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ee81, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100c_ee84, 5); calld(0x100d_4e8c, 0x6003);             /* call 0x100d4e8c */
            ii(0x100c_ee89, 3); mov(memd_a32[ss, ebp - 0x2a], eax);     /* mov [ebp-0x2a], eax */
            ii(0x100c_ee8c, 3); mov(edx, memd_a32[ss, ebp + 0x10]);     /* mov edx, [ebp+0x10] */
            ii(0x100c_ee8f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100c_ee92, 5); calld(0x100d_4d78, 0x5ee1);             /* call 0x100d4d78 */
            ii(0x100c_ee97, 1); pushd(eax);                             /* push eax */
            ii(0x100c_ee98, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_ee9d, 1); pushd(eax);                             /* push eax */
            ii(0x100c_ee9e, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_eea2, 1); pushd(eax);                             /* push eax */
            ii(0x100c_eea3, 4); movsx(ecx, memw_a32[ss, ebp - 0x14]);   /* movsx ecx, word [ebp-0x14] */
            ii(0x100c_eea7, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100c_eeaa, 3); movsx(ebx, memw_a32[ds, ebx]);          /* movsx ebx, word [ebx] */
            ii(0x100c_eead, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_eeb0, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100c_eeb3, 5); calld(0x100e_a99a, 0x1_bae2);           /* call 0x100ea99a */
            ii(0x100c_eeb8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_eebb, 4); cmp(memd_a32[ds, eax + 0x14], 0);       /* cmp dword [eax+0x14], 0x0 */
            ii(0x100c_eebf, 2); if(jzd(0x100c_ef0a, 0x49)) goto l_0x100c_ef0a; /* jz 0x100cef0a */
            ii(0x100c_eec1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_eec4, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100c_eec7, 5); calld(0x100d_4e8c, 0x5fc0);             /* call 0x100d4e8c */
            ii(0x100c_eecc, 3); mov(memd_a32[ss, ebp - 0x2a], eax);     /* mov [ebp-0x2a], eax */
            ii(0x100c_eecf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_eed2, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100c_eed5, 5); calld(0x100d_4f58, 0x607e);             /* call 0x100d4f58 */
            ii(0x100c_eeda, 4); mov(memw_a32[ss, ebp - 0x30], ax);      /* mov [ebp-0x30], ax */
            ii(0x100c_eede, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x100c_eee1, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x100c_eee4, 5); calld(0x100d_4d78, 0x5e8f);             /* call 0x100d4d78 */
            ii(0x100c_eee9, 1); pushd(eax);                             /* push eax */
            ii(0x100c_eeea, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_eeef, 1); pushd(eax);                             /* push eax */
            ii(0x100c_eef0, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_eef4, 1); pushd(eax);                             /* push eax */
            ii(0x100c_eef5, 4); movsx(ecx, memw_a32[ss, ebp - 0x14]);   /* movsx ecx, word [ebp-0x14] */
            ii(0x100c_eef9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_eefc, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_eeff, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_ef02, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100c_ef05, 5); calld(0x100e_a99a, 0x1_ba90);           /* call 0x100ea99a */
        l_0x100c_ef0a:
            ii(0x100c_ef0a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ef0d, 4); cmp(memd_a32[ds, eax + 0x18], 0);       /* cmp dword [eax+0x18], 0x0 */
            ii(0x100c_ef11, 2); if(jzd(0x100c_ef5c, 0x49)) goto l_0x100c_ef5c; /* jz 0x100cef5c */
            ii(0x100c_ef13, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ef16, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100c_ef19, 5); calld(0x100d_4e8c, 0x5f6e);             /* call 0x100d4e8c */
            ii(0x100c_ef1e, 3); mov(memd_a32[ss, ebp - 0x2a], eax);     /* mov [ebp-0x2a], eax */
            ii(0x100c_ef21, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ef24, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100c_ef27, 5); calld(0x100d_4f58, 0x602c);             /* call 0x100d4f58 */
            ii(0x100c_ef2c, 4); mov(memw_a32[ss, ebp - 0x30], ax);      /* mov [ebp-0x30], ax */
            ii(0x100c_ef30, 3); mov(edx, memd_a32[ss, ebp + 0x18]);     /* mov edx, [ebp+0x18] */
            ii(0x100c_ef33, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100c_ef36, 5); calld(0x100d_4d78, 0x5e3d);             /* call 0x100d4d78 */
            ii(0x100c_ef3b, 1); pushd(eax);                             /* push eax */
            ii(0x100c_ef3c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_ef41, 1); pushd(eax);                             /* push eax */
            ii(0x100c_ef42, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_ef46, 1); pushd(eax);                             /* push eax */
            ii(0x100c_ef47, 4); movsx(ecx, memw_a32[ss, ebp - 0x14]);   /* movsx ecx, word [ebp-0x14] */
            ii(0x100c_ef4b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_ef4e, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_ef51, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_ef54, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100c_ef57, 5); calld(0x100e_a99a, 0x1_ba3e);           /* call 0x100ea99a */
        l_0x100c_ef5c:
            ii(0x100c_ef5c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ef5e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_ef5f, 1); popd(edi);                              /* pop edi */
            ii(0x100c_ef60, 1); popd(esi);                              /* pop esi */
            ii(0x100c_ef61, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
