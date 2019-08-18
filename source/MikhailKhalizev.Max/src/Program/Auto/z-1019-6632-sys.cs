using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e155765c-ddba-483e-81bb-c99aeec38488")]
        public void /* sys */ Method_1019_6632()
        {
            ii(0x1019_6632, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_6633, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_6635, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_6636, 1); pushd(esi);                             /* push esi */
            ii(0x1019_6637, 3); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1019_663a, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_663c, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1019_663e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1019_6641, 3); mov(eax, memd_a32[ds, edx + 0x4]);      /* mov eax, [edx+0x4] */
            ii(0x1019_6644, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1019_6647, 2); mov(eax, memd_a32[ds, ebx]);            /* mov eax, [ebx] */
            ii(0x1019_6649, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1019_664c, 3); mov(eax, memd_a32[ds, ebx + 0x4]);      /* mov eax, [ebx+0x4] */
            ii(0x1019_664f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1019_6652, 3); test(cl, 0x40);                         /* test cl, 0x40 */
            ii(0x1019_6655, 2); if(jzd(0x1019_665e, 0x7)) goto l_0x1019_665e; /* jz 0x1019665e */
            ii(0x1019_6657, 5); mov(esi, 0x1);                          /* mov esi, 0x1 */
            ii(0x1019_665c, 2); jmpd(0x1019_6698, 0x3a); goto l_0x1019_6698; /* jmp 0x10196698 */
        l_0x1019_665e:
            ii(0x1019_665e, 3); test(cl, 0x80);                         /* test cl, 0x80 */
            ii(0x1019_6661, 2); if(jzd(0x1019_666a, 0x7)) goto l_0x1019_666a; /* jz 0x1019666a */
            ii(0x1019_6663, 5); mov(esi, 0x2);                          /* mov esi, 0x2 */
            ii(0x1019_6668, 2); jmpd(0x1019_6698, 0x2e); goto l_0x1019_6698; /* jmp 0x10196698 */
        l_0x1019_666a:
            ii(0x1019_666a, 3); test(ch, 0x1);                          /* test ch, 0x1 */
            ii(0x1019_666d, 2); if(jzd(0x1019_6676, 0x7)) goto l_0x1019_6676; /* jz 0x10196676 */
            ii(0x1019_666f, 5); mov(esi, 0x3);                          /* mov esi, 0x3 */
            ii(0x1019_6674, 2); jmpd(0x1019_6698, 0x22); goto l_0x1019_6698; /* jmp 0x10196698 */
        l_0x1019_6676:
            ii(0x1019_6676, 3); test(ch, 0x8);                          /* test ch, 0x8 */
            ii(0x1019_6679, 2); if(jzd(0x1019_6682, 0x7)) goto l_0x1019_6682; /* jz 0x10196682 */
            ii(0x1019_667b, 5); mov(esi, 0x4);                          /* mov esi, 0x4 */
            ii(0x1019_6680, 2); jmpd(0x1019_6698, 0x16); goto l_0x1019_6698; /* jmp 0x10196698 */
        l_0x1019_6682:
            ii(0x1019_6682, 3); test(ch, 0x2);                          /* test ch, 0x2 */
            ii(0x1019_6685, 2); if(jzd(0x1019_668e, 0x7)) goto l_0x1019_668e; /* jz 0x1019668e */
            ii(0x1019_6687, 5); mov(esi, 0x6);                          /* mov esi, 0x6 */
            ii(0x1019_668c, 2); jmpd(0x1019_6698, 0xa); goto l_0x1019_6698; /* jmp 0x10196698 */
        l_0x1019_668e:
            ii(0x1019_668e, 3); test(ch, 0x4);                          /* test ch, 0x4 */
            ii(0x1019_6691, 2); if(jzd(0x1019_6698, 0x5)) goto l_0x1019_6698; /* jz 0x10196698 */
            ii(0x1019_6693, 5); mov(esi, 0x5);                          /* mov esi, 0x5 */
        l_0x1019_6698:
            ii(0x1019_6698, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_669a, 3); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x1019_669d, 7); mov(eax, memd_a32[ds, eax * 4 + 0x101c_1b64]); /* mov eax, [eax*4+0x101c1b64] */
            ii(0x1019_66a4, 3); mov(memd_a32[ss, ebp - 0x28], esi);     /* mov [ebp-0x28], esi */
            ii(0x1019_66a7, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1019_66aa, 3); test(ch, 0x10);                         /* test ch, 0x10 */
            ii(0x1019_66ad, 2); if(jzd(0x1019_66bc, 0xd)) goto l_0x1019_66bc; /* jz 0x101966bc */
            ii(0x1019_66af, 6); fld(memq_a32[ds, 0x101b_7700]);         /* fld qword [0x101b7700] */
            ii(0x1019_66b5, 2); fchs();                                 /* fchs */
            ii(0x1019_66b7, 3); fstp(memq_a32[ss, ebp - 0x10]);         /* fstp qword [ebp-0x10] */
            ii(0x1019_66ba, 2); jmpd(0x1019_66fe, 0x42); goto l_0x1019_66fe; /* jmp 0x101966fe */
        l_0x1019_66bc:
            ii(0x1019_66bc, 3); test(ch, 0x20);                         /* test ch, 0x20 */
            ii(0x1019_66bf, 2); if(jzd(0x1019_66cb, 0xa)) goto l_0x1019_66cb; /* jz 0x101966cb */
            ii(0x1019_66c1, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1019_66c3, 3); mov(memd_a32[ss, ebp - 0x10], ecx);     /* mov [ebp-0x10], ecx */
            ii(0x1019_66c6, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1019_66c9, 2); jmpd(0x1019_66fe, 0x33); goto l_0x1019_66fe; /* jmp 0x101966fe */
        l_0x1019_66cb:
            ii(0x1019_66cb, 3); test(ch, 0x40);                         /* test ch, 0x40 */
            ii(0x1019_66ce, 2); if(jzd(0x1019_66df, 0xf)) goto l_0x1019_66df; /* jz 0x101966df */
            ii(0x1019_66d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_66d2, 5); mov(ebx, 0x3ff0_0000);                  /* mov ebx, 0x3ff00000 */
            ii(0x1019_66d7, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1019_66da, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1019_66dd, 2); jmpd(0x1019_66fe, 0x1f); goto l_0x1019_66fe; /* jmp 0x101966fe */
        l_0x1019_66df:
            ii(0x1019_66df, 3); test(ch, 0x80);                         /* test ch, 0x80 */
            ii(0x1019_66e2, 2); if(jzd(0x1019_66f3, 0xf)) goto l_0x1019_66f3; /* jz 0x101966f3 */
            ii(0x1019_66e4, 5); mov(eax, memd_a32[ds, 0x101b_7700]);    /* mov eax, [0x101b7700] */
            ii(0x1019_66e9, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1019_66ec, 5); mov(eax, memd_a32[ds, 0x101b_7704]);    /* mov eax, [0x101b7704] */
            ii(0x1019_66f1, 2); jmpd(0x1019_66fb, 0x8); goto l_0x1019_66fb; /* jmp 0x101966fb */
        l_0x1019_66f3:
            ii(0x1019_66f3, 2); mov(eax, memd_a32[ds, ebx]);            /* mov eax, [ebx] */
            ii(0x1019_66f5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1019_66f8, 3); mov(eax, memd_a32[ds, ebx + 0x4]);      /* mov eax, [ebx+0x4] */
        l_0x1019_66fb:
            ii(0x1019_66fb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1019_66fe:
            ii(0x1019_66fe, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1019_6701, 5); calld(/* sys */ 0x1019_b7e3, 0x50dd);   /* call 0x1019b7e3 */
            ii(0x1019_6706, 3); lea(esp, ebp - 0x8);                    /* lea esp, [ebp-0x8] */
            ii(0x1019_6709, 1); popd(esi);                              /* pop esi */
            ii(0x1019_670a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_670b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_670c, 1); retd(); return;                         /* ret */
        }
    }
}
