using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_31ef-8ae5506a")]
        public void Method_1008_31ef()
        {
            ii(0x1008_31ef, 5); push(0x38);                             /* push 0x38 */
            ii(0x1008_31f4, 5); call(Definitions.sys_check_available_stack_size, 0xe_2b59); /* call 0x10165d52 */
            ii(0x1008_31f9, 1); push(ebx);                              /* push ebx */
            ii(0x1008_31fa, 1); push(ecx);                              /* push ecx */
            ii(0x1008_31fb, 1); push(esi);                              /* push esi */
            ii(0x1008_31fc, 1); push(edi);                              /* push edi */
            ii(0x1008_31fd, 1); push(ebp);                              /* push ebp */
            ii(0x1008_31fe, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_3200, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1008_3206, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_3209, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_320c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_320f, 3); add(edx, 8);                            /* add edx, 0x8 */
            ii(0x1008_3212, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_3215, 3); add(eax, 0x42);                         /* add eax, 0x42 */
            ii(0x1008_3218, 5); call(0x1008_b268, 0x804b);              /* call 0x1008b268 */
            ii(0x1008_321d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_3220, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1008_3224, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_3226, 2); if(jl(0x1008_3237, 0xf)) goto l_0x1008_3237; /* jl 0x10083237 */
            ii(0x1008_3228, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1008_322c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_322f, 3); add(eax, 0x42);                         /* add eax, 0x42 */
            ii(0x1008_3232, 5); call(0x1008_b32c, 0x80f5);              /* call 0x1008b32c */
        l_0x1008_3237:
            ii(0x1008_3237, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3239, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_323c, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_323f, 5); call(0x1013_ad11, 0xb_7acd);            /* call 0x1013ad11 */
            ii(0x1008_3244, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3246, 2); if(jz(0x1008_3257, 0xf)) goto l_0x1008_3257; /* jz 0x10083257 */
            ii(0x1008_3248, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_324b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_324e, 5); call(0x1008_2abe, -0x795);              /* call 0x10082abe */
            ii(0x1008_3253, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3255, 2); if(jnz(0x1008_325c, 5)) goto l_0x1008_325c; /* jnz 0x1008325c */
        l_0x1008_3257:
            ii(0x1008_3257, 5); jmp(0x1008_3304, 0xa8); goto l_0x1008_3304; /* jmp 0x10083304 */
        l_0x1008_325c:
            ii(0x1008_325c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_325f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_3262, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_3265, 5); call(0x1007_6630, -0xcc3a);             /* call 0x10076630 */
            ii(0x1008_326a, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_326d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_3270, 5); call(0x1015_27ed, 0xc_f578);            /* call 0x101527ed */
            ii(0x1008_3275, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_3278, 5); call(0x1008_acf8, 0x7a7b);              /* call 0x1008acf8 */
            ii(0x1008_327d, 2); test(al, al);                           /* test al, al */
            ii(0x1008_327f, 2); if(jnz(0x1008_32d3, 0x52)) goto l_0x1008_32d3; /* jnz 0x100832d3 */
            ii(0x1008_3281, 5); call(0x1008_a7bc, 0x7536);              /* call 0x1008a7bc */
            ii(0x1008_3286, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_328b, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_328e, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1008_3293, 5); call(Definitions.sys_new, 0xe_2b68);    /* call 0x10165e00 */
            ii(0x1008_3298, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_329b, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_329e, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_32a1, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1008_32a5, 2); if(jz(0x1008_32bd, 0x16)) goto l_0x1008_32bd; /* jz 0x100832bd */
            ii(0x1008_32a7, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_32aa, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_32ad, 5); call(0x100a_3711, 0x2_045f);            /* call 0x100a3711 */
            ii(0x1008_32b2, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_32b5, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_32b8, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_32bb, 2); jmp(0x1008_32c3, 6); goto l_0x1008_32c3; /* jmp 0x100832c3 */
        l_0x1008_32bd:
            ii(0x1008_32bd, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_32c0, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x1008_32c3:
            ii(0x1008_32c3, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x1008_32c6, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_32cb, 3); mov(ebx, memd[ss, ebp - 0x10]);         /* mov ebx, [ebp-0x10] */
            ii(0x1008_32ce, 5); call(0x100a_4db6, 0x2_1ae3);            /* call 0x100a4db6 */
        l_0x1008_32d3:
            ii(0x1008_32d3, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_32d8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_32db, 5); call(0x100a_297d, 0x1_f69d);            /* call 0x100a297d */
            ii(0x1008_32e0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_32e3, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_32e6, 5); call(0x1007_6574, -0xcd77);             /* call 0x10076574 */
            ii(0x1008_32eb, 6); mov(memw[ds, eax + 0x1e], 0);           /* mov word [eax+0x1e], 0x0 */
            ii(0x1008_32f1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_32f4, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_32f7, 5); call(0x1007_6574, -0xcd88);             /* call 0x10076574 */
            ii(0x1008_32fc, 6); mov(memw[ds, eax + 0x20], 0);           /* mov word [eax+0x20], 0x0 */
            ii(0x1008_3302, 2); jmp(0x1008_331a, 0x16); goto l_0x1008_331a; /* jmp 0x1008331a */
        l_0x1008_3304:
            ii(0x1008_3304, 5); call(0x1008_a79c, 0x7493);              /* call 0x1008a79c */
            ii(0x1008_3309, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_330b, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_330d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_3310, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_3315, 5); call(0x100a_53ac, 0x2_2092);            /* call 0x100a53ac */
        l_0x1008_331a:
            ii(0x1008_331a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_331c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_331d, 1); pop(edi);                               /* pop edi */
            ii(0x1008_331e, 1); pop(esi);                               /* pop esi */
            ii(0x1008_331f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_3320, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_3321, 1); ret();                                  /* ret */
        }
    }
}
