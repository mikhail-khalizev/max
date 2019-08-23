using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_cdd2-68260f9a")]
        public void Method_100a_cdd2()
        {
            ii(0x100a_cdd2, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_cdd7, 5); calld(Definitions.sys_check_available_stack_size, 0xb_8f76); /* call 0x10165d52 */
            ii(0x100a_cddc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_cddd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_cdde, 1); pushd(edx);                             /* push edx */
            ii(0x100a_cddf, 1); pushd(esi);                             /* push esi */
            ii(0x100a_cde0, 1); pushd(edi);                             /* push edi */
            ii(0x100a_cde1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_cde2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_cde4, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_cdea, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_cded, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_cdef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_cdf2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_cdf5, 5); calld(0x1013_ad71, 0x8_df77);           /* call 0x1013ad71 */
            ii(0x100a_cdfa, 2); test(al, al);                           /* test al, al */
            ii(0x100a_cdfc, 6); if(jzd(0x100a_cf4d, 0x14b)) goto l_0x100a_cf4d; /* jz 0x100acf4d */
            ii(0x100a_ce02, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ce05, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_ce08, 5); calld(0x1007_6574, -0x3_6899);          /* call 0x10076574 */
            ii(0x100a_ce0d, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100a_ce11, 2); if(jnzd(0x100a_ce24, 0x11)) goto l_0x100a_ce24; /* jnz 0x100ace24 */
            ii(0x100a_ce13, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ce16, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_ce19, 5); calld(0x1007_6574, -0x3_68aa);          /* call 0x10076574 */
            ii(0x100a_ce1e, 4); cmp(memb_a32[ds, eax + 0x3e], 0x4);     /* cmp byte [eax+0x3e], 0x4 */
            ii(0x100a_ce22, 2); if(jzd(0x100a_ce26, 0x2)) goto l_0x100a_ce26; /* jz 0x100ace26 */
        l_0x100a_ce24:
            ii(0x100a_ce24, 2); jmpd(0x100a_ce33, 0xd); goto l_0x100a_ce33; /* jmp 0x100ace33 */
        l_0x100a_ce26:
            ii(0x100a_ce26, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ce29, 3); mov(eax, memd_a32[ds, eax + 0x26]);     /* mov eax, [eax+0x26] */
            ii(0x100a_ce2c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_ce2f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_ce31, 2); if(jld(0x100a_ce38, 0x5)) goto l_0x100a_ce38; /* jl 0x100ace38 */
        l_0x100a_ce33:
            ii(0x100a_ce33, 5); jmpd(0x100a_cecc, 0x94); goto l_0x100a_cecc; /* jmp 0x100acecc */
        l_0x100a_ce38:
            ii(0x100a_ce38, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ce3b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_ce3e, 5); calld(0x1007_6574, -0x3_68cf);          /* call 0x10076574 */
            ii(0x100a_ce43, 5); calld(0x1007_611c, -0x3_6d2c);          /* call 0x1007611c */
            ii(0x100a_ce48, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_ce4a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_ce4d, 5); calld(0x1007_66ac, -0x3_67a6);          /* call 0x100766ac */
            ii(0x100a_ce52, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_ce54, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_ce57, 5); calld(0x1013_ad71, 0x8_df15);           /* call 0x1013ad71 */
            ii(0x100a_ce5c, 2); test(al, al);                           /* test al, al */
            ii(0x100a_ce5e, 2); if(jzd(0x100a_ce69, 0x9)) goto l_0x100a_ce69; /* jz 0x100ace69 */
            ii(0x100a_ce60, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100a_ce67, 2); jmpd(0x100a_ce82, 0x19); goto l_0x100a_ce82; /* jmp 0x100ace82 */
        l_0x100a_ce69:
            ii(0x100a_ce69, 5); mov(ecx, 0x270);                        /* mov ecx, 0x270 */
            ii(0x100a_ce6e, 5); mov(ebx, StringDefinitions.AiMoveCpp3); /* mov ebx, 0x101a0e8d */
            ii(0x100a_ce73, 5); mov(edx, StringDefinitions.TransportNotEqual0); /* mov edx, 0x101a0e99 */
            ii(0x100a_ce78, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_ce7a, 5); calld(Definitions.sys_assert, 0xb_8f13); /* call 0x10165d92 */
            ii(0x100a_ce7f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x100a_ce82:
            ii(0x100a_ce82, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_ce85, 5); calld(0x1007_6574, -0x3_6916);          /* call 0x10076574 */
            ii(0x100a_ce8a, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x100a_ce8e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ce91, 4); mov(memw_a32[ds, eax + 0x28], dx);      /* mov [eax+0x28], dx */
            ii(0x100a_ce95, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_ce98, 5); calld(0x1007_6574, -0x3_6929);          /* call 0x10076574 */
            ii(0x100a_ce9d, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x100a_cea1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_cea4, 4); mov(memw_a32[ds, eax + 0x2a], dx);      /* mov [eax+0x2a], dx */
            ii(0x100a_cea8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ceab, 5); calld(0x100a_c6ba, -0x7f6);             /* call 0x100ac6ba */
            ii(0x100a_ceb0, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_ceb5, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_ceb8, 5); calld(0x1007_65d0, -0x3_68ed);          /* call 0x100765d0 */
            ii(0x100a_cebd, 5); calld(0x100a_297d, -0xa545);            /* call 0x100a297d */
            ii(0x100a_cec2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_cec4, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_cec7, 5); calld(0x1007_5f2c, -0x3_6fa0);          /* call 0x10075f2c */
        l_0x100a_cecc:
            ii(0x100a_cecc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_cece, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ced1, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100a_ced4, 5); calld(0x1013_ad11, 0x8_de38);           /* call 0x1013ad11 */
            ii(0x100a_ced9, 2); test(al, al);                           /* test al, al */
            ii(0x100a_cedb, 2); if(jzd(0x100a_cef4, 0x17)) goto l_0x100a_cef4; /* jz 0x100acef4 */
            ii(0x100a_cedd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_cee0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_cee3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_cee6, 5); calld(0x1007_6574, -0x3_6977);          /* call 0x10076574 */
            ii(0x100a_ceeb, 5); calld(0x1015_2a52, 0xa_5b62);           /* call 0x10152a52 */
            ii(0x100a_cef0, 2); test(al, al);                           /* test al, al */
            ii(0x100a_cef2, 2); if(jnzd(0x100a_cef6, 0x2)) goto l_0x100a_cef6; /* jnz 0x100acef6 */
        l_0x100a_cef4:
            ii(0x100a_cef4, 2); jmpd(0x100a_cf4d, 0x57); goto l_0x100a_cf4d; /* jmp 0x100acf4d */
        l_0x100a_cef6:
            ii(0x100a_cef6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_cef9, 5); cmp(memw_a32[ds, eax + 0x26], -0x1 /* 0xff */); /* cmp word [eax+0x26], 0xffff */
            ii(0x100a_cefe, 2); if(jzd(0x100a_cf10, 0x10)) goto l_0x100a_cf10; /* jz 0x100acf10 */
            ii(0x100a_cf00, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_cf03, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_cf06, 5); calld(Definitions.my_3_get_count, -0x2_1a8b); /* call 0x1008b480 */
            ii(0x100a_cf0b, 1); cwde();                                 /* cwde */
            ii(0x100a_cf0c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_cf0e, 2); if(jzd(0x100a_cf12, 0x2)) goto l_0x100a_cf12; /* jz 0x100acf12 */
        l_0x100a_cf10:
            ii(0x100a_cf10, 2); jmpd(0x100a_cf21, 0xf); goto l_0x100a_cf21; /* jmp 0x100acf21 */
        l_0x100a_cf12:
            ii(0x100a_cf12, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_cf17, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_cf1a, 5); calld(0x100a_cbbb, -0x364);             /* call 0x100acbbb */
            ii(0x100a_cf1f, 2); jmpd(0x100a_cf4d, 0x2c); goto l_0x100a_cf4d; /* jmp 0x100acf4d */
        l_0x100a_cf21:
            ii(0x100a_cf21, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_cf24, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_cf27, 5); calld(0x1007_6574, -0x3_69b8);          /* call 0x10076574 */
            ii(0x100a_cf2c, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100a_cf2f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_cf34, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_cf36, 2); if(jled(0x100a_cf4d, 0x15)) goto l_0x100a_cf4d; /* jle 0x100acf4d */
            ii(0x100a_cf38, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_cf3d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_cf40, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_cf43, 5); calld(0x1007_65d0, -0x3_6978);          /* call 0x100765d0 */
            ii(0x100a_cf48, 5); calld(0x100a_297d, -0xa5d0);            /* call 0x100a297d */
        l_0x100a_cf4d:
            ii(0x100a_cf4d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_cf4f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_cf50, 1); popd(edi);                              /* pop edi */
            ii(0x100a_cf51, 1); popd(esi);                              /* pop esi */
            ii(0x100a_cf52, 1); popd(edx);                              /* pop edx */
            ii(0x100a_cf53, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_cf54, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_cf55, 1); retd();                                 /* ret */
        }
    }
}
