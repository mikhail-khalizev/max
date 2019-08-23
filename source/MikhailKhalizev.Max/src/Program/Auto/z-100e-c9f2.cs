using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_c9f2-c709c4b9")]
        public void Method_100e_c9f2()
        {
            ii(0x100e_c9f2, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100e_c9f7, 5); calld(Definitions.sys_check_available_stack_size, 0x7_9356); /* call 0x10165d52 */
            ii(0x100e_c9fc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_c9fd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_c9fe, 1); pushd(esi);                             /* push esi */
            ii(0x100e_c9ff, 1); pushd(edi);                             /* push edi */
            ii(0x100e_ca00, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_ca01, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_ca03, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100e_ca09, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_ca0c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_ca0f, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100e_ca13, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_ca16, 5); calld(0x1007_64fc, -0x7_651f);          /* call 0x100764fc */
            ii(0x100e_ca1b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_ca1e, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100e_ca22, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100e_ca29, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_ca2d, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100e_ca30, 7); test(memb_a32[ds, eax + 0x101c_81c1], 0x2); /* test byte [eax+0x101c81c1], 0x2 */
            ii(0x100e_ca37, 2); if(jzd(0x100e_ca51, 0x18)) goto l_0x100e_ca51; /* jz 0x100eca51 */
            ii(0x100e_ca39, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100e_ca3e, 5); calld(0x1007_6338, -0x7_670b);          /* call 0x10076338 */
            ii(0x100e_ca43, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100e_ca46, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_ca48, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_ca4a, 5); calld(0x1007_643c, -0x7_6613);          /* call 0x1007643c */
            ii(0x100e_ca4f, 2); jmpd(0x100e_ca67, 0x16); goto l_0x100e_ca67; /* jmp 0x100eca67 */
        l_0x100e_ca51:
            ii(0x100e_ca51, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100e_ca56, 5); calld(0x1007_6338, -0x7_6723);          /* call 0x10076338 */
            ii(0x100e_ca5b, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100e_ca5e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_ca60, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_ca62, 5); calld(0x1007_643c, -0x7_662b);          /* call 0x1007643c */
        l_0x100e_ca67:
            ii(0x100e_ca67, 2); jmpd(0x100e_ca71, 0x8); goto l_0x100e_ca71; /* jmp 0x100eca71 */
        l_0x100e_ca69:
            ii(0x100e_ca69, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_ca6c, 5); calld(0x1007_6bf8, -0x7_5e79);          /* call 0x10076bf8 */
        l_0x100e_ca71:
            ii(0x100e_ca71, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_ca73, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_ca76, 5); calld(0x1013_ad71, 0x4_e2f6);           /* call 0x1013ad71 */
            ii(0x100e_ca7b, 2); test(al, al);                           /* test al, al */
            ii(0x100e_ca7d, 2); if(jzd(0x100e_cad1, 0x52)) goto l_0x100e_cad1; /* jz 0x100ecad1 */
            ii(0x100e_ca7f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_ca82, 5); calld(0x1007_63a0, -0x7_66e7);          /* call 0x100763a0 */
            ii(0x100e_ca87, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_ca89, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_ca8c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_ca90, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_ca92, 2); if(jnzd(0x100e_caa2, 0xe)) goto l_0x100e_caa2; /* jnz 0x100ecaa2 */
            ii(0x100e_ca94, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_ca97, 5); calld(0x1007_63a0, -0x7_66fc);          /* call 0x100763a0 */
            ii(0x100e_ca9c, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100e_caa0, 2); if(jzd(0x100e_caa4, 0x2)) goto l_0x100e_caa4; /* jz 0x100ecaa4 */
        l_0x100e_caa2:
            ii(0x100e_caa2, 2); jmpd(0x100e_cab2, 0xe); goto l_0x100e_cab2; /* jmp 0x100ecab2 */
        l_0x100e_caa4:
            ii(0x100e_caa4, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_caa7, 5); calld(0x1007_63a0, -0x7_670c);          /* call 0x100763a0 */
            ii(0x100e_caac, 4); cmp(memb_a32[ds, eax + 0x45], 0);       /* cmp byte [eax+0x45], 0x0 */
            ii(0x100e_cab0, 2); if(jnzd(0x100e_cab4, 0x2)) goto l_0x100e_cab4; /* jnz 0x100ecab4 */
        l_0x100e_cab2:
            ii(0x100e_cab2, 2); jmpd(0x100e_cac7, 0x13); goto l_0x100e_cac7; /* jmp 0x100ecac7 */
        l_0x100e_cab4:
            ii(0x100e_cab4, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_cab7, 5); calld(0x1007_63a0, -0x7_671c);          /* call 0x100763a0 */
            ii(0x100e_cabc, 5); calld(0x1015_0a9e, 0x6_3fdd);           /* call 0x10150a9e */
            ii(0x100e_cac1, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100e_cac5, 2); if(jzd(0x100e_cac9, 0x2)) goto l_0x100e_cac9; /* jz 0x100ecac9 */
        l_0x100e_cac7:
            ii(0x100e_cac7, 2); jmpd(0x100e_cacf, 0x6); goto l_0x100e_cacf; /* jmp 0x100ecacf */
        l_0x100e_cac9:
            ii(0x100e_cac9, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_cacc, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x100e_cacf:
            ii(0x100e_cacf, 2); jmpd(0x100e_ca69, -0x68); goto l_0x100e_ca69; /* jmp 0x100eca69 */
        l_0x100e_cad1:
            ii(0x100e_cad1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_cad4, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_cad7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_cad9, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100e_cadc, 5); calld(0x1007_5f6c, -0x7_6b75);          /* call 0x10075f6c */
            ii(0x100e_cae1, 2); jmpd(0x100e_caed, 0xa); goto l_0x100e_caed; /* jmp 0x100ecaed */
        //  ii(0x100e_cae3, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100e_cae5, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
        //  ii(0x100e_cae8, 5); calld(0x1007_5f6c, -0x7_6b81);          /* call 0x10075f6c */
        l_0x100e_caed:
            ii(0x100e_caed, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_caf0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_caf2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_caf3, 1); popd(edi);                              /* pop edi */
            ii(0x100e_caf4, 1); popd(esi);                              /* pop esi */
            ii(0x100e_caf5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_caf6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_caf7, 1); retd();                                 /* ret */
        }
    }
}
