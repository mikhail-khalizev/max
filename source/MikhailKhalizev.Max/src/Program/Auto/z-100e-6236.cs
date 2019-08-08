using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8c8f155e-0043-48da-b175-a90020031545")]
        public void Method_100e_6236()
        {
            ii(0x100e_6236, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_623b, 5); calld(Definitions.sys_check_available_stack_size, 0x7_fb12); /* call 0x10165d52 */
            ii(0x100e_6240, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_6241, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_6242, 1); pushd(edx);                             /* push edx */
            ii(0x100e_6243, 1); pushd(esi);                             /* push esi */
            ii(0x100e_6244, 1); pushd(edi);                             /* push edi */
            ii(0x100e_6245, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_6246, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_6248, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_624e, 7); cmp(memd_a32[ds, 0x101c_3630], 0);      /* cmp dword [0x101c3630], 0x0 */
            ii(0x100e_6255, 2); if(jzd(0x100e_626b, 0x14)) goto l_0x100e_626b; /* jz 0x100e626b */
            ii(0x100e_6257, 5); mov(eax, memd_a32[ds, 0x101c_3630]);    /* mov eax, [0x101c3630] */
            ii(0x100e_625c, 5); calld(Definitions.sys_free, 0x8_4e60);  /* call 0x1016b0c1 */
            ii(0x100e_6261, 10); mov(memd_a32[ds, 0x101c_3630], 0);     /* mov dword [0x101c3630], 0x0 */
        l_0x100e_626b:
            ii(0x100e_626b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_626d, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_6272, 5); calld(0x1013_ad11, 0x5_4a9a);           /* call 0x1013ad11 */
            ii(0x100e_6277, 2); test(al, al);                           /* test al, al */
            ii(0x100e_6279, 6); if(jnzd(0x100e_6342, 0xc3)) goto l_0x100e_6342; /* jnz 0x100e6342 */
            ii(0x100e_627f, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100e_6284, 5); calld(0x1007_6600, -0x6_fc89);          /* call 0x10076600 */
            ii(0x100e_6289, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_628c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_628f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_6291, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_6294, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_6296, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100e_629b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_629d, 6); if(jnzd(0x100e_6342, 0x9f)) goto l_0x100e_6342; /* jnz 0x100e6342 */
            ii(0x100e_62a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_62a6, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100e_62aa, 2); if(jzd(0x100e_62cb, 0x1f)) goto l_0x100e_62cb; /* jz 0x100e62cb */
            ii(0x100e_62ac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_62af, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100e_62b3, 2); if(jnzd(0x100e_62be, 0x9)) goto l_0x100e_62be; /* jnz 0x100e62be */
            ii(0x100e_62b5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_62b8, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100e_62bc, 2); if(jzd(0x100e_62c0, 0x2)) goto l_0x100e_62c0; /* jz 0x100e62c0 */
        l_0x100e_62be:
            ii(0x100e_62be, 2); jmpd(0x100e_62c9, 0x9); goto l_0x100e_62c9; /* jmp 0x100e62c9 */
        l_0x100e_62c0:
            ii(0x100e_62c0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_62c3, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x100e_62c7, 2); if(jzd(0x100e_62cb, 0x2)) goto l_0x100e_62cb; /* jz 0x100e62cb */
        l_0x100e_62c9:
            ii(0x100e_62c9, 2); jmpd(0x100e_62cd, 0x2); goto l_0x100e_62cd; /* jmp 0x100e62cd */
        l_0x100e_62cb:
            ii(0x100e_62cb, 2); jmpd(0x100e_62cf, 0x2); goto l_0x100e_62cf; /* jmp 0x100e62cf */
        l_0x100e_62cd:
            ii(0x100e_62cd, 2); jmpd(0x100e_6342, 0x73); goto l_0x100e_6342; /* jmp 0x100e6342 */
        l_0x100e_62cf:
            ii(0x100e_62cf, 6); mov(ax, memw_a32[ds, 0x101b_7f42]);     /* mov ax, [0x101b7f42] */
            ii(0x100e_62d5, 7); dec(memw_a32[ds, 0x101b_7f42]);         /* dec word [0x101b7f42] */
            ii(0x100e_62dc, 1); cwde();                                 /* cwde */
            ii(0x100e_62dd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_62df, 2); if(jnzd(0x100e_6307, 0x26)) goto l_0x100e_6307; /* jnz 0x100e6307 */
            ii(0x100e_62e1, 7); inc(memw_a32[ds, 0x101c_3610]);         /* inc word [0x101c3610] */
            ii(0x100e_62e8, 5); mov(eax, memd_a32[ds, 0x101c_360e]);    /* mov eax, [0x101c360e] */
            ii(0x100e_62ed, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_62f0, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x100e_62f3, 2); if(jbd(0x100e_62fe, 0x9)) goto l_0x100e_62fe; /* jb 0x100e62fe */
            ii(0x100e_62f5, 9); mov(memw_a32[ds, 0x101c_3610], 0);      /* mov word [0x101c3610], 0x0 */
        l_0x100e_62fe:
            ii(0x100e_62fe, 9); mov(memw_a32[ds, 0x101b_7f42], 0x2);    /* mov word [0x101b7f42], 0x2 */
        l_0x100e_6307:
            ii(0x100e_6307, 5); mov(eax, memd_a32[ds, 0x101c_360e]);    /* mov eax, [0x101c360e] */
            ii(0x100e_630c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_630f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_6311, 6); mov(eax, memd_a32[ds, eax + 0x101b_7f36]); /* mov eax, [eax+0x101b7f36] */
            ii(0x100e_6317, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_631a, 5); calld(Definitions.my_get_res_data_by_id, 0x4_dcb9); /* call 0x10133fd8 */
            ii(0x100e_631f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_6322, 6); mov(edx, memd_a32[ds, 0x101c_38c4]);    /* mov edx, [0x101c38c4] */
            ii(0x100e_6328, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_632b, 5); calld(0x100e_8f38, 0x2c08);             /* call 0x100e8f38 */
            ii(0x100e_6330, 5); mov(memd_a32[ds, 0x101c_3630], eax);    /* mov [0x101c3630], eax */
            ii(0x100e_6335, 5); mov(edx, 0x100e_5fe7);                  /* mov edx, 0x100e5fe7 */
            ii(0x100e_633a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_633d, 5); calld(0x100e_603a, -0x308);             /* call 0x100e603a */
        l_0x100e_6342:
            ii(0x100e_6342, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_6344, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_6345, 1); popd(edi);                              /* pop edi */
            ii(0x100e_6346, 1); popd(esi);                              /* pop esi */
            ii(0x100e_6347, 1); popd(edx);                              /* pop edx */
            ii(0x100e_6348, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_6349, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_634a, 1); retd(); return;                         /* ret */
        }
    }
}
