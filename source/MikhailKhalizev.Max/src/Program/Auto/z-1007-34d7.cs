using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_34d7-6aaf6128")]
        public void Method_1007_34d7()
        {
            ii(0x1007_34d7, 5); push(0x34);                             /* push 0x34 */
            ii(0x1007_34dc, 5); call(Definitions.sys_check_available_stack_size, 0xf_2871); /* call 0x10165d52 */
            ii(0x1007_34e1, 1); push(ebx);                              /* push ebx */
            ii(0x1007_34e2, 1); push(ecx);                              /* push ecx */
            ii(0x1007_34e3, 1); push(edx);                              /* push edx */
            ii(0x1007_34e4, 1); push(esi);                              /* push esi */
            ii(0x1007_34e5, 1); push(edi);                              /* push edi */
            ii(0x1007_34e6, 1); push(ebp);                              /* push ebp */
            ii(0x1007_34e7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_34e9, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1007_34ef, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_34f2, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x1007_34f6, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1007_34f9, 5); call(0x1007_64fc, 0x2ffe);              /* call 0x100764fc */
            ii(0x1007_34fe, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1007_3501, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x1007_3505, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_3508, 5); cmp(memw[ds, eax + 8], 0xa);            /* cmp word [eax+0x8], 0xa */
            ii(0x1007_350d, 2); if(jnz(0x1007_3527, 0x18)) goto l_0x1007_3527; /* jnz 0x10073527 */
            ii(0x1007_350f, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1007_3514, 5); call(0x1007_6338, 0x2e1f);              /* call 0x10076338 */
            ii(0x1007_3519, 3); lea(ebx, memd[ss, ebp - 24]);           /* lea ebx, [ebp-0x18] */
            ii(0x1007_351c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_351e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_3520, 5); call(0x1007_643c, 0x2f17);              /* call 0x1007643c */
            ii(0x1007_3525, 2); jmp(0x1007_353d, 0x16); goto l_0x1007_353d; /* jmp 0x1007353d */
        l_0x1007_3527:
            ii(0x1007_3527, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1007_352c, 5); call(0x1007_6338, 0x2e07);              /* call 0x10076338 */
            ii(0x1007_3531, 3); lea(ebx, memd[ss, ebp - 24]);           /* lea ebx, [ebp-0x18] */
            ii(0x1007_3534, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_3536, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_3538, 5); call(0x1007_643c, 0x2eff);              /* call 0x1007643c */
        l_0x1007_353d:
            ii(0x1007_353d, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
        l_0x1007_3544:
            ii(0x1007_3544, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3546, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1007_3549, 5); call(0x1013_ad71, 0xc_7823);            /* call 0x1013ad71 */
            ii(0x1007_354e, 2); test(al, al);                           /* test al, al */
            ii(0x1007_3550, 2); if(jz(0x1007_3584, 0x32)) goto l_0x1007_3584; /* jz 0x10073584 */
            ii(0x1007_3552, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1007_3555, 5); call(0x1007_63a0, 0x2e46);              /* call 0x100763a0 */
            ii(0x1007_355a, 4); cmp(memb[ds, eax + 61], 0x10);          /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_355e, 2); if(jnz(0x1007_3572, 0x12)) goto l_0x1007_3572; /* jnz 0x10073572 */
            ii(0x1007_3560, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1007_3563, 5); call(0x1007_63a0, 0x2e38);              /* call 0x100763a0 */
            ii(0x1007_3568, 5); call(0x1007_611c, 0x2baf);              /* call 0x1007611c */
            ii(0x1007_356d, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1007_3570, 2); if(jz(0x1007_3574, 2)) goto l_0x1007_3574; /* jz 0x10073574 */
        l_0x1007_3572:
            ii(0x1007_3572, 2); jmp(0x1007_357a, 6); goto l_0x1007_357a; /* jmp 0x1007357a */
        l_0x1007_3574:
            ii(0x1007_3574, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_3577, 3); inc(memd[ss, ebp - 12]);                /* inc dword [ebp-0xc] */
        l_0x1007_357a:
            ii(0x1007_357a, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1007_357d, 5); call(0x1007_6bf8, 0x3676);              /* call 0x10076bf8 */
            ii(0x1007_3582, 2); jmp(0x1007_3544, -0x40); goto l_0x1007_3544; /* jmp 0x10073544 */
        l_0x1007_3584:
            ii(0x1007_3584, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_3587, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1007_358a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_358c, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1007_358f, 5); call(0x1007_5f6c, 0x29d8);              /* call 0x10075f6c */
            ii(0x1007_3594, 2); jmp(0x1007_35a0, 0xa); goto l_0x1007_35a0; /* jmp 0x100735a0 */
        //  ii(0x1007_3596, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_3598, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
        //  ii(0x1007_359b, 5); call(0x1007_5f6c, 0x29cc);              /* call 0x10075f6c */
        l_0x1007_35a0:
            ii(0x1007_35a0, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_35a3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_35a5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_35a6, 1); pop(edi);                               /* pop edi */
            ii(0x1007_35a7, 1); pop(esi);                               /* pop esi */
            ii(0x1007_35a8, 1); pop(edx);                               /* pop edx */
            ii(0x1007_35a9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_35aa, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_35ab, 1); ret();                                  /* ret */
        }
    }
}
