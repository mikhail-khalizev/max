using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6ac3b22b-5ecd-43ea-809c-8043b2cf6b2a")]
        public void Method_100b_32d1()
        {
            ii(0x100b_32d1, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100b_32d6, 5); calld(Definitions.sys_check_available_stack_size, 0xb_2a77); /* call 0x10165d52 */
            ii(0x100b_32db, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_32dc, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_32dd, 1); pushd(edx);                             /* push edx */
            ii(0x100b_32de, 1); pushd(esi);                             /* push esi */
            ii(0x100b_32df, 1); pushd(edi);                             /* push edi */
            ii(0x100b_32e0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_32e1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_32e3, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_32e9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_32ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_32ee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_32f1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_32f4, 5); calld(0x1013_ad11, 0x8_7a18);           /* call 0x1013ad11 */
            ii(0x100b_32f9, 2); test(al, al);                           /* test al, al */
            ii(0x100b_32fb, 2); if(jnzd(0x100b_3314, 0x17)) goto l_0x100b_3314; /* jnz 0x100b3314 */
            ii(0x100b_32fd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_3300, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3303, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3306, 5); calld(0x1007_6574, -0x3_cd97);          /* call 0x10076574 */
            ii(0x100b_330b, 5); calld(0x1015_2a52, 0x9_f742);           /* call 0x10152a52 */
            ii(0x100b_3310, 2); test(al, al);                           /* test al, al */
            ii(0x100b_3312, 2); if(jnzd(0x100b_3319, 0x5)) goto l_0x100b_3319; /* jnz 0x100b3319 */
        l_0x100b_3314:
            ii(0x100b_3314, 5); jmpd(0x100b_339b, 0x82); goto l_0x100b_339b; /* jmp 0x100b339b */
        l_0x100b_3319:
            ii(0x100b_3319, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_331c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_331f, 5); calld(0x1007_6574, -0x3_cdb0);          /* call 0x10076574 */
            ii(0x100b_3324, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_3327, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_332a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_332d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3330, 5); calld(0x1007_6574, -0x3_cdc1);          /* call 0x10076574 */
            ii(0x100b_3335, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100b_3338, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_333b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_333e, 5); calld(0x1007_6aac, -0x3_c897);          /* call 0x10076aac */
            ii(0x100b_3343, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_3345, 1); pushd(eax);                             /* push eax */
            ii(0x100b_3346, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3349, 3); mov(ecx, memd_a32[ds, eax + 0x1e]);     /* mov ecx, [eax+0x1e] */
            ii(0x100b_334c, 3); sar(ecx, 0x18);                         /* sar ecx, 0x18 */
            ii(0x100b_334f, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x100b_3352, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_3355, 5); calld(0x1007_5e64, -0x3_d4f6);          /* call 0x10075e64 */
            ii(0x100b_335a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_335c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_335f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3362, 5); calld(0x1007_65d0, -0x3_cd97);          /* call 0x100765d0 */
            ii(0x100b_3367, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_3369, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_336c, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_336f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_3372, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100b_3378, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x100b_337d, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100b_337f, 5); calld(0x100c_20df, 0xed5b);             /* call 0x100c20df */
            ii(0x100b_3384, 1); cwde();                                 /* cwde */
            ii(0x100b_3385, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_3387, 2); if(jnzd(0x100b_3393, 0xa)) goto l_0x100b_3393; /* jnz 0x100b3393 */
            ii(0x100b_3389, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_338c, 5); calld(0x100b_375b, 0x3ca);              /* call 0x100b375b */
            ii(0x100b_3391, 2); jmpd(0x100b_339b, 0x8); goto l_0x100b_339b; /* jmp 0x100b339b */
        l_0x100b_3393:
            ii(0x100b_3393, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3396, 5); calld(0x100b_33a4, 0x9);                /* call 0x100b33a4 */
        l_0x100b_339b:
            ii(0x100b_339b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_339d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_339e, 1); popd(edi);                              /* pop edi */
            ii(0x100b_339f, 1); popd(esi);                              /* pop esi */
            ii(0x100b_33a0, 1); popd(edx);                              /* pop edx */
            ii(0x100b_33a1, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_33a2, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_33a3, 1); retd(); return;                         /* ret */
        }
    }
}
