using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("af2ce9dd-19c4-4b97-ad18-340c850342a1")]
        public void Method_1014_69b5()
        {
            ii(0x1014_69b5, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1014_69ba, 5); calld(Definitions.sys_check_available_stack_size, 0x1_f393); /* call 0x10165d52 */
            ii(0x1014_69bf, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_69c0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_69c1, 1); pushd(edx);                             /* push edx */
            ii(0x1014_69c2, 1); pushd(esi);                             /* push esi */
            ii(0x1014_69c3, 1); pushd(edi);                             /* push edi */
            ii(0x1014_69c4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_69c5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_69c7, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_69cd, 4); or(memb_a32[ss, ebp - 0x4], 0x1);       /* or byte [ebp-0x4], 0x1 */
            ii(0x1014_69d1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_69d4, 5); calld(Definitions.my_string_ctor, -0x4ef1); /* call 0x10141ae8 */
            ii(0x1014_69d9, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_69dc, 4); and(memb_a32[ss, ebp - 0x4], -0x2 /* 0xfe */); /* and byte [ebp-0x4], 0xfe */
            ii(0x1014_69e0, 1); int3();                                 /* int3 */
            ii(0x1014_69e1, 5); calld(/* sys */ 0x1016_66b0, 0x1_fcca); /* call 0x101666b0 */
            ii(0x1014_69e6, 5); calld(/* sys */ 0x1017_1880, 0x2_ae95); /* call 0x10171880 */
            ii(0x1014_69eb, 3); lea(eax, ebp + 0x24);                   /* lea eax, [ebp+0x24] */
            ii(0x1014_69ee, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_69f1, 3); lea(ecx, ebp - 0xc);                    /* lea ecx, [ebp-0xc] */
            ii(0x1014_69f4, 3); mov(ebx, memd_a32[ss, ebp + 0x20]);     /* mov ebx, [ebp+0x20] */
            ii(0x1014_69f7, 5); mov(edx, 0x12c);                        /* mov edx, 0x12c */
            ii(0x1014_69fc, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_69ff, 5); calld(0x1014_20d7, -0x492d);            /* call 0x101420d7 */
            ii(0x1014_6a04, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_6a0b, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1014_6a0e, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1014_6a11, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_6a14, 1); pushd(eax);                             /* push eax */
            ii(0x1014_6a15, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1014_6a18, 3); mov(ecx, memd_a32[ds, eax + 0x16]);     /* mov ecx, [eax+0x16] */
            ii(0x1014_6a1b, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1014_6a1e, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1014_6a21, 5); calld(Definitions.my_strobj_c_str_v2, -0xb_d25e); /* call 0x100897c8 */
            ii(0x1014_6a26, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_6a28, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_6a2b, 5); calld(Definitions.my_strobj_c_str_v2, -0xb_d268); /* call 0x100897c8 */
            ii(0x1014_6a30, 3); lea(esi, ebp - 0x8);                    /* lea esi, [ebp-0x8] */
            ii(0x1014_6a33, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_6a35, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1014_6a37, 5); calld(0x1014_5056, -0x19e6);            /* call 0x10145056 */
            ii(0x1014_6a3c, 5); calld(Definitions.my_strobj_c_str_v2, -0xb_d279); /* call 0x100897c8 */
            ii(0x1014_6a41, 5); calld(/* sys */ 0x1018_0f20, 0x3_a4da); /* call 0x10180f20 */
            ii(0x1014_6a46, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6a48, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_6a4b, 5); calld(Definitions.my_string_dtor, -0x4f26); /* call 0x10141b2a */
            ii(0x1014_6a50, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1014_6a55, 5); calld(Definitions.sys_exit, 0x2_5c05);  /* call 0x1016c65f */
            ii(0x1014_6a5a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6a5c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_6a5f, 5); calld(Definitions.my_string_dtor, -0x4f3a); /* call 0x10141b2a */
            ii(0x1014_6a64, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_6a66, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_6a67, 1); popd(edi);                              /* pop edi */
            ii(0x1014_6a68, 1); popd(esi);                              /* pop esi */
            ii(0x1014_6a69, 1); popd(edx);                              /* pop edx */
            ii(0x1014_6a6a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_6a6b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_6a6c, 1); retd(); return;                         /* ret */
        }
    }
}
