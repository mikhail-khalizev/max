using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_764d-8f5ffea")]
        public void Method_1008_764d()
        {
            ii(0x1008_764d, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_7652, 5); calld(Definitions.sys_check_available_stack_size, 0xd_e6fb); /* call 0x10165d52 */
            ii(0x1008_7657, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_7658, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_7659, 1); pushd(edx);                             /* push edx */
            ii(0x1008_765a, 1); pushd(esi);                             /* push esi */
            ii(0x1008_765b, 1); pushd(edi);                             /* push edi */
            ii(0x1008_765c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_765d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_765f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_7665, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_7668, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_766b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_766e, 5); calld(0x1007_6338, -0x1_133b);          /* call 0x10076338 */
            ii(0x1008_7673, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1008_7676, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_7678, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_767a, 5); calld(0x1007_64b8, -0x1_11c7);          /* call 0x100764b8 */
            ii(0x1008_767f, 2); jmpd(0x1008_7689, 0x8); goto l_0x1008_7689; /* jmp 0x10087689 */
        l_0x1008_7681:
            ii(0x1008_7681, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_7684, 5); calld(0x1007_6bf8, -0x1_0a91);          /* call 0x10076bf8 */
        l_0x1008_7689:
            ii(0x1008_7689, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_768b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_768e, 5); calld(0x1013_ad71, 0xb_36de);           /* call 0x1013ad71 */
            ii(0x1008_7693, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7695, 2); if(jzd(0x1008_76fa, 0x63)) goto l_0x1008_76fa; /* jz 0x100876fa */
            ii(0x1008_7697, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_769a, 5); calld(0x1007_63d4, -0x1_12cb);          /* call 0x100763d4 */
            ii(0x1008_769f, 5); calld(0x1007_b8d1, -0xbdd3);            /* call 0x1007b8d1 */
            ii(0x1008_76a4, 2); test(al, al);                           /* test al, al */
            ii(0x1008_76a6, 2); if(jzd(0x1008_76b8, 0x10)) goto l_0x1008_76b8; /* jz 0x100876b8 */
            ii(0x1008_76a8, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_76ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_76ae, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_76b1, 5); calld(0x1007_5f6c, -0x1_174a);          /* call 0x10075f6c */
            ii(0x1008_76b6, 2); jmpd(0x1008_7714, 0x5c); goto l_0x1008_7714; /* jmp 0x10087714 */
        l_0x1008_76b8:
            ii(0x1008_76b8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_76bb, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_76be, 5); calld(0x1007_63a0, -0x1_1323);          /* call 0x100763a0 */
            ii(0x1008_76c3, 5); calld(0x1015_2a52, 0xc_b38a);           /* call 0x10152a52 */
            ii(0x1008_76c8, 2); test(al, al);                           /* test al, al */
            ii(0x1008_76ca, 2); if(jzd(0x1008_76e0, 0x14)) goto l_0x1008_76e0; /* jz 0x100876e0 */
            ii(0x1008_76cc, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_76cf, 5); calld(0x1007_63a0, -0x1_1334);          /* call 0x100763a0 */
            ii(0x1008_76d4, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1008_76d7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_76dc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_76de, 2); if(jgd(0x1008_76e2, 0x2)) goto l_0x1008_76e2; /* jg 0x100876e2 */
        l_0x1008_76e0:
            ii(0x1008_76e0, 2); jmpd(0x1008_76f8, 0x16); goto l_0x1008_76f8; /* jmp 0x100876f8 */
        l_0x1008_76e2:
            ii(0x1008_76e2, 5); calld(0x1008_b0e4, 0x39fd);             /* call 0x1008b0e4 */
            ii(0x1008_76e7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_76e9, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1008_76eb, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_76ee, 5); calld(0x1007_63d4, -0x1_131f);          /* call 0x100763d4 */
            ii(0x1008_76f3, 5); calld(0x100a_297d, 0x1_b285);           /* call 0x100a297d */
        l_0x1008_76f8:
            ii(0x1008_76f8, 2); jmpd(0x1008_7681, -0x79); goto l_0x1008_7681; /* jmp 0x10087681 */
        l_0x1008_76fa:
            ii(0x1008_76fa, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_76fe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7700, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_7703, 5); calld(0x1007_5f6c, -0x1_179c);          /* call 0x10075f6c */
            ii(0x1008_7708, 2); jmpd(0x1008_7714, 0xa); goto l_0x1008_7714; /* jmp 0x10087714 */
        //  ii(0x1008_770a, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_770c, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
        //  ii(0x1008_770f, 5); calld(0x1007_5f6c, -0x1_17a8);          /* call 0x10075f6c */
        l_0x1008_7714:
            ii(0x1008_7714, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_7717, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7719, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_771a, 1); popd(edi);                              /* pop edi */
            ii(0x1008_771b, 1); popd(esi);                              /* pop esi */
            ii(0x1008_771c, 1); popd(edx);                              /* pop edx */
            ii(0x1008_771d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_771e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_771f, 1); retd();                                 /* ret */
        }
    }
}
