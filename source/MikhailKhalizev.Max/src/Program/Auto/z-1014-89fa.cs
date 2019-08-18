using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dc3ae02b-5f41-45c5-aca7-11bb92c2e192")]
        public void Method_1014_89fa()
        {
            ii(0x1014_89fa, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1014_89ff, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d34e); /* call 0x10165d52 */
            ii(0x1014_8a04, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_8a05, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_8a06, 1); pushd(edx);                             /* push edx */
            ii(0x1014_8a07, 1); pushd(esi);                             /* push esi */
            ii(0x1014_8a08, 1); pushd(edi);                             /* push edi */
            ii(0x1014_8a09, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_8a0a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_8a0c, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1014_8a12, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8a15, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8a18, 5); calld(0x1014_4ef4, -0x3b29);            /* call 0x10144ef4 */
            ii(0x1014_8a1d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8a20, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_8a23, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1014_8a26, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8a29, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_8a2c, 5); calld(0x1012_0d24, -0x2_7d0d);          /* call 0x10120d24 */
            ii(0x1014_8a31, 3); sub(eax, 0x65);                         /* sub eax, 0x65 */
            ii(0x1014_8a34, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8a37, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_8a3a, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1014_8a3d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8a40, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_8a43, 5); calld(Definitions.my_ctor_0x101b_38d0, -0xd_2204); /* call 0x10076844 */
            ii(0x1014_8a48, 3); sub(eax, 0x6c);                         /* sub eax, 0x6c */
            ii(0x1014_8a4b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8a4e, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_8a51, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_8a54, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8a57, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_8a5a, 5); calld(0x1007_6998, -0xd_20c7);          /* call 0x10076998 */
            ii(0x1014_8a5f, 3); sub(eax, 0x70);                         /* sub eax, 0x70 */
            ii(0x1014_8a62, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8a65, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_8a68, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_8a6b, 5); calld(0x1008_b3ec, -0xb_d684);          /* call 0x1008b3ec */
            ii(0x1014_8a70, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_8a73, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8a76, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1014_8a79, 5); calld(0x1008_b1e4, -0xb_d89a);          /* call 0x1008b1e4 */
            ii(0x1014_8a7e, 3); sub(eax, 0x74);                         /* sub eax, 0x74 */
            ii(0x1014_8a81, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8a84, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_8a87, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_8a8a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8a8d, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1014_8a92, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xd_23a7); /* call 0x100766f0 */
            ii(0x1014_8a97, 5); sub(eax, 0x82);                         /* sub eax, 0x82 */
            ii(0x1014_8a9c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8a9f, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_8aa2, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_8aa5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8aa8, 5); add(eax, 0x86);                         /* add eax, 0x86 */
            ii(0x1014_8aad, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xd_23c2); /* call 0x100766f0 */
            ii(0x1014_8ab2, 5); sub(eax, 0x86);                         /* sub eax, 0x86 */
            ii(0x1014_8ab7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8aba, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_8abd, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_8ac0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8ac3, 5); add(eax, 0x8a);                         /* add eax, 0x8a */
            ii(0x1014_8ac8, 5); calld(0x1009_ca70, -0xa_c05d);          /* call 0x1009ca70 */
            ii(0x1014_8acd, 5); sub(eax, 0x8a);                         /* sub eax, 0x8a */
            ii(0x1014_8ad2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8ad5, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_8ad8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_8adb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8ade, 5); add(eax, 0x94);                         /* add eax, 0x94 */
            ii(0x1014_8ae3, 5); calld(0x1009_ca70, -0xa_c078);          /* call 0x1009ca70 */
            ii(0x1014_8ae8, 5); sub(eax, 0x94);                         /* sub eax, 0x94 */
            ii(0x1014_8aed, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8af0, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_8af3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8af6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8af9, 5); add(eax, 0x9f);                         /* add eax, 0x9f */
            ii(0x1014_8afe, 5); calld(Definitions.my_ctor_0x101b_4184, -0xd_2013); /* call 0x10076af0 */
            ii(0x1014_8b03, 5); sub(eax, 0x9f);                         /* sub eax, 0x9f */
            ii(0x1014_8b08, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8b0b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8b0e, 5); add(eax, 0xd9);                         /* add eax, 0xd9 */
            ii(0x1014_8b13, 5); calld(Definitions.my_ctor_0x101b_4184, -0xd_2028); /* call 0x10076af0 */
            ii(0x1014_8b18, 5); sub(eax, 0xd9);                         /* sub eax, 0xd9 */
            ii(0x1014_8b1d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8b20, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8b23, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_7398); /* mov dword [eax+0x2], 0x101b7398 */
            ii(0x1014_8b2a, 7); inc(memw_a32[ds, 0x101c_8148]);         /* inc word [0x101c8148] */
            ii(0x1014_8b31, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8b34, 6); mov(memw_a32[ds, eax + 0x8], 0xffff);   /* mov word [eax+0x8], 0xffff */
            ii(0x1014_8b3a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8b3d, 7); mov(memd_a32[ds, eax + 0xa], 0);        /* mov dword [eax+0xa], 0x0 */
            ii(0x1014_8b44, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8b47, 7); mov(memd_a32[ds, eax + 0xe], 0);        /* mov dword [eax+0xe], 0x0 */
            ii(0x1014_8b4e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8b51, 7); mov(memb_a32[ds, eax + 0x9e], 0);       /* mov byte [eax+0x9e], 0x0 */
            ii(0x1014_8b58, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8b5b, 9); mov(memw_a32[ds, eax + 0xa3], 0);       /* mov word [eax+0xa3], 0x0 */
            ii(0x1014_8b64, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8b67, 7); mov(memb_a32[ds, eax + 0xa5], 0x1);     /* mov byte [eax+0xa5], 0x1 */
            ii(0x1014_8b6e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8b71, 7); mov(memd_a32[ds, eax + 0x7e], 0);       /* mov dword [eax+0x7e], 0x0 */
            ii(0x1014_8b78, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8b7b, 4); mov(memb_a32[ds, eax + 0x4f], 0);       /* mov byte [eax+0x4f], 0x0 */
            ii(0x1014_8b7f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8b82, 10); mov(memd_a32[ds, eax + 0xa7], 0);      /* mov dword [eax+0xa7], 0x0 */
            ii(0x1014_8b8c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8b8f, 6); mov(memw_a32[ds, eax + 0x78], 0x1);     /* mov word [eax+0x78], 0x1 */
            ii(0x1014_8b95, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8b98, 10); mov(memd_a32[ds, eax + 0xdd], 0);      /* mov dword [eax+0xdd], 0x0 */
            ii(0x1014_8ba2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8ba5, 4); mov(memb_a32[ds, eax + 0x5b], 0);       /* mov byte [eax+0x5b], 0x0 */
            ii(0x1014_8ba9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8bac, 4); mov(memb_a32[ds, eax + 0x5c], 0);       /* mov byte [eax+0x5c], 0x0 */
            ii(0x1014_8bb0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8bb3, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1014_8bb6, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1014_8bb9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_8bbb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_8bbc, 1); popd(edi);                              /* pop edi */
            ii(0x1014_8bbd, 1); popd(esi);                              /* pop esi */
            ii(0x1014_8bbe, 1); popd(edx);                              /* pop edx */
            ii(0x1014_8bbf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_8bc0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_8bc1, 1); retd(); return;                         /* ret */
        }
    }
}
