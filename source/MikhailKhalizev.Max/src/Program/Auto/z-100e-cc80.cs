using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("371686b7-9081-4a41-bc61-ca1db94e049b")]
        public void Method_100e_cc80()
        {
            ii(0x100e_cc80, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100e_cc85, 5); calld(Definitions.sys_check_available_stack_size, 0x7_90c8); /* call 0x10165d52 */
            ii(0x100e_cc8a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_cc8b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_cc8c, 1); pushd(esi);                             /* push esi */
            ii(0x100e_cc8d, 1); pushd(edi);                             /* push edi */
            ii(0x100e_cc8e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_cc8f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_cc91, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_cc97, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_cc9a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_cc9d, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_cca1, 5); calld(0x100e_c3fc, -0x8aa);             /* call 0x100ec3fc */
            ii(0x100e_cca6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_cca8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_ccab, 5); calld(0x1007_64b8, -0x7_67f8);          /* call 0x100764b8 */
            ii(0x100e_ccb0, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_ccb7, 2); jmpd(0x100e_ccc1, 0x8); goto l_0x100e_ccc1; /* jmp 0x100eccc1 */
        l_0x100e_ccb9:
            ii(0x100e_ccb9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_ccbc, 5); calld(0x1007_6bf8, -0x7_60c9);          /* call 0x10076bf8 */
        l_0x100e_ccc1:
            ii(0x100e_ccc1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_ccc3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_ccc6, 5); calld(0x1013_ad71, 0x4_e0a6);           /* call 0x1013ad71 */
            ii(0x100e_cccb, 2); test(al, al);                           /* test al, al */
            ii(0x100e_cccd, 2); if(jzd(0x100e_cd26, 0x57)) goto l_0x100e_cd26; /* jz 0x100ecd26 */
            ii(0x100e_cccf, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_ccd2, 5); calld(0x1007_63a0, -0x7_6937);          /* call 0x100763a0 */
            ii(0x100e_ccd7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_ccd9, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_ccdc, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_cce0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_cce2, 2); if(jnzd(0x100e_ccf6, 0x12)) goto l_0x100e_ccf6; /* jnz 0x100eccf6 */
            ii(0x100e_cce4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_cce7, 5); calld(0x1007_63a0, -0x7_694c);          /* call 0x100763a0 */
            ii(0x100e_ccec, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100e_ccf0, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100e_ccf4, 2); if(jzd(0x100e_ccf8, 0x2)) goto l_0x100e_ccf8; /* jz 0x100eccf8 */
        l_0x100e_ccf6:
            ii(0x100e_ccf6, 2); jmpd(0x100e_cd1c, 0x24); goto l_0x100e_cd1c; /* jmp 0x100ecd1c */
        l_0x100e_ccf8:
            ii(0x100e_ccf8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_ccfb, 5); calld(0x1007_63a0, -0x7_6960);          /* call 0x100763a0 */
            ii(0x100e_cd00, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_cd02, 3); mov(dl, memb_a32[ds, eax + 0x54]);      /* mov dl, [eax+0x54] */
            ii(0x100e_cd05, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_cd08, 5); calld(0x1007_63a0, -0x7_696d);          /* call 0x100763a0 */
            ii(0x100e_cd0d, 5); calld(0x1007_623c, -0x7_6ad6);          /* call 0x1007623c */
            ii(0x100e_cd12, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x100e_cd15, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_cd18, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_cd1a, 2); if(jnzd(0x100e_cd1e, 0x2)) goto l_0x100e_cd1e; /* jnz 0x100ecd1e */
        l_0x100e_cd1c:
            ii(0x100e_cd1c, 2); jmpd(0x100e_cd24, 0x6); goto l_0x100e_cd24; /* jmp 0x100ecd24 */
        l_0x100e_cd1e:
            ii(0x100e_cd1e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_cd21, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100e_cd24:
            ii(0x100e_cd24, 2); jmpd(0x100e_ccb9, -0x6d); goto l_0x100e_ccb9; /* jmp 0x100eccb9 */
        l_0x100e_cd26:
            ii(0x100e_cd26, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100e_cd29, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100e_cd2c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_cd2e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_cd31, 5); calld(0x1007_5f6c, -0x7_6dca);          /* call 0x10075f6c */
            ii(0x100e_cd36, 2); jmpd(0x100e_cd42, 0xa); goto l_0x100e_cd42; /* jmp 0x100ecd42 */
        //    ii(0x100e_cd38, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100e_cd3a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //    ii(0x100e_cd3d, 5); calld(0x1007_5f6c, -0x7_6dd6);          /* call 0x10075f6c */
        l_0x100e_cd42:
            ii(0x100e_cd42, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100e_cd45, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_cd47, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_cd48, 1); popd(edi);                              /* pop edi */
            ii(0x100e_cd49, 1); popd(esi);                              /* pop esi */
            ii(0x100e_cd4a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_cd4b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_cd4c, 1); retd(); return;                         /* ret */
        }
    }
}
