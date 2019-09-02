using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_32c3-be3b78e0")]
        public void Method_100a_32c3()
        {
            ii(0x100a_32c3, 5); push(0x50);                             /* push 0x50 */
            ii(0x100a_32c8, 5); call(Definitions.sys_check_available_stack_size, 0xc_2a85); /* call 0x10165d52 */
            ii(0x100a_32cd, 1); push(ebx);                              /* push ebx */
            ii(0x100a_32ce, 1); push(ecx);                              /* push ecx */
            ii(0x100a_32cf, 1); push(esi);                              /* push esi */
            ii(0x100a_32d0, 1); push(edi);                              /* push edi */
            ii(0x100a_32d1, 1); push(ebp);                              /* push ebp */
            ii(0x100a_32d2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_32d4, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100a_32da, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_32dd, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x100a_32e0, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_32e3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_32e5, 3); mov(al, memb[ds, edx + 0x26]);          /* mov al, [edx+0x26] */
            ii(0x100a_32e8, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_32ee, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x100a_32f3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_32f5, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100a_32f8, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_32fb, 3); mov(ebx, memd[ds, edx + 0x1a]);         /* mov ebx, [edx+0x1a] */
            ii(0x100a_32fe, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_3301, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_3304, 3); mov(edx, memd[ds, edx + 0x18]);         /* mov edx, [edx+0x18] */
            ii(0x100a_3307, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_330a, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_330d, 5); call(0x1007_6aac, -0x2_c866);           /* call 0x10076aac */
            ii(0x100a_3312, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_3314, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_3317, 3); mov(al, memb[ds, edx + 0x4d]);          /* mov al, [edx+0x4d] */
            ii(0x100a_331a, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_331d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_3320, 5); call(0x1008_aa80, -0x1_88a5);           /* call 0x1008aa80 */
            ii(0x100a_3325, 2); test(al, 1);                            /* test al, 0x1 */
            ii(0x100a_3327, 2); if(jz(0x100a_3332, 9)) goto l_0x100a_3332; /* jz 0x100a3332 */
            ii(0x100a_3329, 4); mov(memb[ss, ebp - 0x18], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x100a_332d, 5); jmp(0x100a_345f, 0x12d); goto l_0x100a_345f; /* jmp 0x100a345f */
        l_0x100a_3332:
            ii(0x100a_3332, 4); cmp(memb[ss, ebp - 4], 3);              /* cmp byte [ebp-0x4], 0x3 */
            ii(0x100a_3336, 2); if(jnz(0x100a_333f, 7)) goto l_0x100a_333f; /* jnz 0x100a333f */
            ii(0x100a_3338, 7); mov(memd[ss, ebp - 0x14], 1);           /* mov dword [ebp-0x14], 0x1 */
        l_0x100a_333f:
            ii(0x100a_333f, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100a_3344, 1); push(eax);                              /* push eax */
            ii(0x100a_3345, 4); movsx(ecx, memb[ss, ebp - 4]);          /* movsx ecx, byte [ebp-0x4] */
            ii(0x100a_3349, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x100a_334c, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100a_334f, 5); call(0x1007_5e64, -0x2_d4f0);           /* call 0x10075e64 */
            ii(0x100a_3354, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_3357, 3); mov(esi, memd[ss, ebp - 0xc]);          /* mov esi, [ebp-0xc] */
            ii(0x100a_335a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_335c, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100a_335e, 5); call(0x100c_20df, 0x1_ed7c);            /* call 0x100c20df */
            ii(0x100a_3363, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x100a_3367, 2); if(jge(0x100a_3372, 9)) goto l_0x100a_3372; /* jge 0x100a3372 */
            ii(0x100a_3369, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
            ii(0x100a_336d, 5); jmp(0x100a_345f, 0xed); goto l_0x100a_345f; /* jmp 0x100a345f */
        l_0x100a_3372:
            ii(0x100a_3372, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_3375, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x100a_3378, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_337d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_337f, 2); if(jnz(0x100a_338a, 9)) goto l_0x100a_338a; /* jnz 0x100a338a */
            ii(0x100a_3381, 4); mov(memb[ss, ebp - 0x18], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x100a_3385, 5); jmp(0x100a_345f, 0xd5); goto l_0x100a_345f; /* jmp 0x100a345f */
        l_0x100a_338a:
            ii(0x100a_338a, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100a_338f, 4); movsx(ebx, memb[ss, ebp - 4]);          /* movsx ebx, byte [ebp-0x4] */
            ii(0x100a_3393, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_3396, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_3399, 5); call(0x100c_1fd4, 0x1_ec36);            /* call 0x100c1fd4 */
            ii(0x100a_339e, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100a_33a1, 4); cmp(memd[ss, ebp - 0x20], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100a_33a5, 2); if(jnz(0x100a_33b0, 9)) goto l_0x100a_33b0; /* jnz 0x100a33b0 */
            ii(0x100a_33a7, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
            ii(0x100a_33ab, 5); jmp(0x100a_345f, 0xaf); goto l_0x100a_345f; /* jmp 0x100a345f */
        l_0x100a_33b0:
            ii(0x100a_33b0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_33b3, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x100a_33b6, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100a_33b8, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100a_33bb, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x100a_33be, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100a_33c1, 5); call(0x1007_5e64, -0x2_d562);           /* call 0x10075e64 */
            ii(0x100a_33c6, 3); lea(ecx, memd[ss, ebp - 0x34]);         /* lea ecx, [ebp-0x34] */
            ii(0x100a_33c9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_33cb, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100a_33cd, 5); call(0x100a_95c1, 0x61ef);              /* call 0x100a95c1 */
        l_0x100a_33d2:
            ii(0x100a_33d2, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x100a_33d5, 5); call(0x1008_9860, -0x1_9b7a);           /* call 0x10089860 */
            ii(0x100a_33da, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_33dd, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100a_33e0, 3); add(edx, memd[ss, ebp - 0x20]);         /* add edx, [ebp-0x20] */
            ii(0x100a_33e3, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x100a_33e6, 5); call(0x1008_982c, -0x1_9bbf);           /* call 0x1008982c */
            ii(0x100a_33eb, 1); cwde();                                 /* cwde */
            ii(0x100a_33ec, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100a_33ee, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100a_33f0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_33f2, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100a_33f5, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x100a_33f9, 2); if(jge(0x100a_3435, 0x3a)) goto l_0x100a_3435; /* jge 0x100a3435 */
            ii(0x100a_33fb, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x100a_3400, 1); push(eax);                              /* push eax */
            ii(0x100a_3401, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x100a_3404, 5); call(0x1008_982c, -0x1_9bdd);           /* call 0x1008982c */
            ii(0x100a_3409, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100a_340c, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x100a_340f, 5); call(0x1008_9860, -0x1_9bb4);           /* call 0x10089860 */
            ii(0x100a_3414, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100a_3417, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_341a, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100a_341d, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100a_341f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_3422, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_3425, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100a_3428, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_342b, 5); call(0x1007_02b9, -0x3_3177);           /* call 0x100702b9 */
            ii(0x100a_3430, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100a_3433, 2); if(jnz(0x100a_3437, 2)) goto l_0x100a_3437; /* jnz 0x100a3437 */
        l_0x100a_3435:
            ii(0x100a_3435, 2); jmp(0x100a_343d, 6); goto l_0x100a_343d; /* jmp 0x100a343d */
        l_0x100a_3437:
            ii(0x100a_3437, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
            ii(0x100a_343b, 2); jmp(0x100a_345f, 0x22); goto l_0x100a_345f; /* jmp 0x100a345f */
        l_0x100a_343d:
            ii(0x100a_343d, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x100a_3440, 5); call(0x100a_96db, 0x6296);              /* call 0x100a96db */
            ii(0x100a_3445, 2); test(al, al);                           /* test al, al */
            ii(0x100a_3447, 2); if(jnz(0x100a_33d2, -0x77)) goto l_0x100a_33d2; /* jnz 0x100a33d2 */
            ii(0x100a_3449, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x100a_344e, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100a_3453, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_3456, 5); call(0x100a_b120, 0x7cc5);              /* call 0x100ab120 */
            ii(0x100a_345b, 4); mov(memb[ss, ebp - 0x18], 1);           /* mov byte [ebp-0x18], 0x1 */
        l_0x100a_345f:
            ii(0x100a_345f, 3); mov(al, memb[ss, ebp - 0x18]);          /* mov al, [ebp-0x18] */
            ii(0x100a_3462, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3464, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_3465, 1); pop(edi);                               /* pop edi */
            ii(0x100a_3466, 1); pop(esi);                               /* pop esi */
            ii(0x100a_3467, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_3468, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_3469, 1); ret();                                  /* ret */
        }
    }
}
