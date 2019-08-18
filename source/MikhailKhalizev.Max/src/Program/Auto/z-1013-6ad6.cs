using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6ad6-f16ab3b5")]
        public void Method_1013_6ad6()
        {
            ii(0x1013_6ad6, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x1013_6adb, 5); calld(Definitions.sys_check_available_stack_size, 0x2_f272); /* call 0x10165d52 */
            ii(0x1013_6ae0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_6ae1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_6ae2, 1); pushd(edx);                             /* push edx */
            ii(0x1013_6ae3, 1); pushd(esi);                             /* push esi */
            ii(0x1013_6ae4, 1); pushd(edi);                             /* push edi */
            ii(0x1013_6ae5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_6ae6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6ae8, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1013_6aee, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_6af1, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1013_6af6, 5); calld(Definitions.sys_new, 0x2_f305);   /* call 0x10165e00 */
            ii(0x1013_6afb, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1013_6afe, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_6b01, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1013_6b04, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1013_6b08, 2); if(jzd(0x1013_6b42, 0x38)) goto l_0x1013_6b42; /* jz 0x10136b42 */
            ii(0x1013_6b0a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6b0d, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1013_6b10, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_6b13, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6b14, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6b17, 3); mov(ecx, memd_a32[ds, eax + 0xa]);      /* mov ecx, [eax+0xa] */
            ii(0x1013_6b1a, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1013_6b1d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6b20, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x1013_6b23, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1013_6b26, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6b29, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1013_6b2c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_6b2f, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_6b32, 5); calld(0x100d_7bdc, -0x5_ef5b);          /* call 0x100d7bdc */
            ii(0x1013_6b37, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1013_6b3a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1013_6b3d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_6b40, 2); jmpd(0x1013_6b48, 0x6); goto l_0x1013_6b48; /* jmp 0x10136b48 */
        l_0x1013_6b42:
            ii(0x1013_6b42, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1013_6b45, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1013_6b48:
            ii(0x1013_6b48, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_6b4b, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_6b4e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6b51, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_6b53, 3); mov(memd_a32[ss, ebp - 0x32], eax);     /* mov [ebp-0x32], eax */
            ii(0x1013_6b56, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6b59, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_6b5b, 5); calld(/* sys */ 0x1016_7dd4, 0x3_1274); /* call 0x10167dd4 */
            ii(0x1013_6b60, 3); mov(memd_a32[ss, ebp - 0x2e], eax);     /* mov [ebp-0x2e], eax */
            ii(0x1013_6b63, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6b66, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_6b68, 5); calld(/* sys */ 0x1016_7e3c, 0x3_12cf); /* call 0x10167e3c */
            ii(0x1013_6b6d, 4); mov(memw_a32[ss, ebp - 0x34], ax);      /* mov [ebp-0x34], ax */
            ii(0x1013_6b71, 3); lea(edx, ebp - 0x44);                   /* lea edx, [ebp-0x44] */
            ii(0x1013_6b74, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_6b77, 5); calld(0x100d_7d74, -0x5_ee08);          /* call 0x100d7d74 */
            ii(0x1013_6b7c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6b7f, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x1013_6b82, 5); calld(/* sys */ 0x1016_965c, 0x3_2ad5); /* call 0x1016965c */
            ii(0x1013_6b87, 3); lea(edx, ebp - 0x44);                   /* lea edx, [ebp-0x44] */
            ii(0x1013_6b8a, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_6b8d, 5); calld(0x100d_7f6c, -0x5_ec26);          /* call 0x100d7f6c */
            ii(0x1013_6b92, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_6b95, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_6b98, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1013_6b9c, 2); if(jzd(0x1013_6bb2, 0x14)) goto l_0x1013_6bb2; /* jz 0x10136bb2 */
            ii(0x1013_6b9e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_6ba0, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_6ba3, 5); calld(Definitions.my_dtor_d3, -0x5_ee75); /* call 0x100d7d33 */
            ii(0x1013_6ba8, 5); calld(Definitions.sys_delete, 0x2_f3b7); /* call 0x10165f64 */
            ii(0x1013_6bad, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_6bb0, 2); jmpd(0x1013_6bb9, 0x7); goto l_0x1013_6bb9; /* jmp 0x10136bb9 */
        l_0x1013_6bb2:
            ii(0x1013_6bb2, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1013_6bb9:
            ii(0x1013_6bb9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6bbc, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x1013_6bbf, 5); calld(Definitions.sys_delete, 0x2_f3a0); /* call 0x10165f64 */
            ii(0x1013_6bc4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6bc7, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1013_6bca, 5); calld(Definitions.sys_delete, 0x2_f395); /* call 0x10165f64 */
            ii(0x1013_6bcf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_6bd2, 3); mov(eax, memd_a32[ds, eax + 0x4f]);     /* mov eax, [eax+0x4f] */
            ii(0x1013_6bd5, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_6bd8, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1013_6bdc, 2); if(jzd(0x1013_6bf2, 0x14)) goto l_0x1013_6bf2; /* jz 0x10136bf2 */
            ii(0x1013_6bde, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_6be0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_6be3, 5); calld(Definitions.my_dtor_d6, -0x4_bb11); /* call 0x100eb0d7 */
            ii(0x1013_6be8, 5); calld(Definitions.sys_delete, 0x2_f377); /* call 0x10165f64 */
            ii(0x1013_6bed, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_6bf0, 2); jmpd(0x1013_6bf9, 0x7); goto l_0x1013_6bf9; /* jmp 0x10136bf9 */
        l_0x1013_6bf2:
            ii(0x1013_6bf2, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x1013_6bf9:
            ii(0x1013_6bf9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_6bfb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_6bfc, 1); popd(edi);                              /* pop edi */
            ii(0x1013_6bfd, 1); popd(esi);                              /* pop esi */
            ii(0x1013_6bfe, 1); popd(edx);                              /* pop edx */
            ii(0x1013_6bff, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_6c00, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_6c01, 1); retd(); return;                         /* ret */
        }
    }
}
