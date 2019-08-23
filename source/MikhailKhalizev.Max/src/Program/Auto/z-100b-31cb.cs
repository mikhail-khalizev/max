using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_31cb-a7abcd40")]
        public void Method_100b_31cb()
        {
            ii(0x100b_31cb, 5); push(0x28);                             /* push 0x28 */
            ii(0x100b_31d0, 5); call(Definitions.sys_check_available_stack_size, 0xb_2b7d); /* call 0x10165d52 */
            ii(0x100b_31d5, 1); push(ebx);                              /* push ebx */
            ii(0x100b_31d6, 1); push(ecx);                              /* push ecx */
            ii(0x100b_31d7, 1); push(edx);                              /* push edx */
            ii(0x100b_31d8, 1); push(esi);                              /* push esi */
            ii(0x100b_31d9, 1); push(edi);                              /* push edi */
            ii(0x100b_31da, 1); push(ebp);                              /* push ebp */
            ii(0x100b_31db, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_31dd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_31e3, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_31e6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_31e9, 6); mov(memw[ds, eax + 0x17], 0);           /* mov word [eax+0x17], 0x0 */
            ii(0x100b_31ef, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_31f2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_31f5, 5); call(0x1007_6574, -0x3_cc86);           /* call 0x10076574 */
            ii(0x100b_31fa, 4); mov(bx, memw[ds, eax + 0x1a]);          /* mov bx, [eax+0x1a] */
            ii(0x100b_31fe, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3201, 4); mov(memw[ds, eax + 0x19], bx);          /* mov [eax+0x19], bx */
            ii(0x100b_3205, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3208, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_320b, 5); call(0x1007_6574, -0x3_cc9c);           /* call 0x10076574 */
            ii(0x100b_3210, 4); mov(bx, memw[ds, eax + 0x1c]);          /* mov bx, [eax+0x1c] */
            ii(0x100b_3214, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3217, 4); mov(memw[ds, eax + 0x1b], bx);          /* mov [eax+0x1b], bx */
            ii(0x100b_321b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_321e, 6); mov(memw[ds, eax + 0x1d], 0x6);         /* mov word [eax+0x1d], 0x6 */
            ii(0x100b_3224, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3227, 6); mov(memw[ds, eax + 0x1f], 0);           /* mov word [eax+0x1f], 0x0 */
            ii(0x100b_322d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3230, 4); mov(memb[ds, eax + 0x22], 0x1);         /* mov byte [eax+0x22], 0x1 */
            ii(0x100b_3234, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3237, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_323a, 5); call(0x1007_6574, -0x3_cccb);           /* call 0x10076574 */
            ii(0x100b_323f, 5); call(0x1015_2700, 0x9_f4bc);            /* call 0x10152700 */
            ii(0x100b_3244, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x100b_3247, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_3249, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_324b, 5); call(0x1008_ae70, -0x2_83e0);           /* call 0x1008ae70 */
            ii(0x100b_3250, 2); jmp(0x100b_325a, 0x8); goto l_0x100b_325a; /* jmp 0x100b325a */
        l_0x100b_3252:
            ii(0x100b_3252, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_3255, 5); call(0x1007_6bf8, -0x3_c662);           /* call 0x10076bf8 */
        l_0x100b_325a:
            ii(0x100b_325a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_325c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_325f, 5); call(0x1013_ad71, 0x8_7b0d);            /* call 0x1013ad71 */
            ii(0x100b_3264, 2); test(al, al);                           /* test al, al */
            ii(0x100b_3266, 2); if(jz(0x100b_329e, 0x36)) goto l_0x100b_329e; /* jz 0x100b329e */
            ii(0x100b_3268, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_326b, 5); call(0x1008_adc4, -0x2_84ac);           /* call 0x1008adc4 */
            ii(0x100b_3270, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_3273, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_3276, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100b_3279, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_327c, 3); call_abs(memd[ds, edx + 0x20]);         /* call dword [edx+0x20] */
            ii(0x100b_327f, 2); cmp(al, 0x26);                          /* cmp al, 0x26 */
            ii(0x100b_3281, 2); if(jnz(0x100b_329c, 0x19)) goto l_0x100b_329c; /* jnz 0x100b329c */
            ii(0x100b_3283, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_3286, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_328b, 5); call(0x100a_5e27, -0xd469);             /* call 0x100a5e27 */
            ii(0x100b_3290, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3292, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_3295, 5); call(0x1008_8bbc, -0x2_a6de);           /* call 0x10088bbc */
            ii(0x100b_329a, 2); jmp(0x100b_32c8, 0x2c); goto l_0x100b_32c8; /* jmp 0x100b32c8 */
        l_0x100b_329c:
            ii(0x100b_329c, 2); jmp(0x100b_3252, -0x4c); goto l_0x100b_3252; /* jmp 0x100b3252 */
        l_0x100b_329e:
            ii(0x100b_329e, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_32a1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_32a4, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_32a7, 5); call(0x1007_6574, -0x3_cd38);           /* call 0x10076574 */
            ii(0x100b_32ac, 5); call(0x1015_27ed, 0x9_f53c);            /* call 0x101527ed */
            ii(0x100b_32b1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_32b6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_32b9, 5); call(0x100a_28ff, -0x1_09bf);           /* call 0x100a28ff */
            ii(0x100b_32be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_32c0, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_32c3, 5); call(0x1008_8bbc, -0x2_a70c);           /* call 0x10088bbc */
        l_0x100b_32c8:
            ii(0x100b_32c8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_32ca, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_32cb, 1); pop(edi);                               /* pop edi */
            ii(0x100b_32cc, 1); pop(esi);                               /* pop esi */
            ii(0x100b_32cd, 1); pop(edx);                               /* pop edx */
            ii(0x100b_32ce, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_32cf, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_32d0, 1); ret();                                  /* ret */
        }
    }
}
