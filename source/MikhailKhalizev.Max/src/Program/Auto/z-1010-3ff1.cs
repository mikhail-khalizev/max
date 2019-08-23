using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_3ff1-d3249cde")]
        public void Method_1010_3ff1()
        {
            ii(0x1010_3ff1, 5); push(0x30);                             /* push 0x30 */
            ii(0x1010_3ff6, 5); call(Definitions.sys_check_available_stack_size, 0x6_1d57); /* call 0x10165d52 */
            ii(0x1010_3ffb, 1); push(ebx);                              /* push ebx */
            ii(0x1010_3ffc, 1); push(ecx);                              /* push ecx */
            ii(0x1010_3ffd, 1); push(edx);                              /* push edx */
            ii(0x1010_3ffe, 1); push(esi);                              /* push esi */
            ii(0x1010_3fff, 1); push(edi);                              /* push edi */
            ii(0x1010_4000, 1); push(ebp);                              /* push ebp */
            ii(0x1010_4001, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4003, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_4009, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_400c, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x1010_4010, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_4013, 5); call(0x1007_64fc, -0x8_db1c);           /* call 0x100764fc */
            ii(0x1010_4018, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_401b, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1010_401f, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1010_4026, 2); jmp(0x1010_402e, 0x6); goto l_0x1010_402e; /* jmp 0x1010402e */
        l_0x1010_4028:
            ii(0x1010_4028, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_402b, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x1010_402e:
            ii(0x1010_402e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_4031, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_4034, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x1010_4037, 2); if(jge(0x1010_40a3, 0x6a)) goto l_0x1010_40a3; /* jge 0x101040a3 */
            ii(0x1010_4039, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_403d, 3); imul(edx, edx, 0xa);                    /* imul edx, edx, 0xa */
            ii(0x1010_4040, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_4043, 3); mov(eax, memd[ds, eax + 0x2]);          /* mov eax, [eax+0x2] */
            ii(0x1010_4046, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_4048, 5); call(0x1007_6338, -0x8_dd15);           /* call 0x10076338 */
            ii(0x1010_404d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_404f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_4052, 5); call(0x1007_643c, -0x8_dc1b);           /* call 0x1007643c */
            ii(0x1010_4057, 2); jmp(0x1010_4061, 0x8); goto l_0x1010_4061; /* jmp 0x10104061 */
        l_0x1010_4059:
            ii(0x1010_4059, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_405c, 5); call(0x1007_6bf8, -0x8_d469);           /* call 0x10076bf8 */
        l_0x1010_4061:
            ii(0x1010_4061, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_4063, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_4066, 5); call(0x1013_ad71, 0x3_6d06);            /* call 0x1013ad71 */
            ii(0x1010_406b, 2); test(al, al);                           /* test al, al */
            ii(0x1010_406d, 2); if(jz(0x1010_408d, 0x1e)) goto l_0x1010_408d; /* jz 0x1010408d */
            ii(0x1010_406f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_4072, 5); call(0x1007_63a0, -0x8_dcd7);           /* call 0x100763a0 */
            ii(0x1010_4077, 5); call(0x1014_b6bd, 0x4_7641);            /* call 0x1014b6bd */
            ii(0x1010_407c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_407e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_4081, 5); call(0x1007_63a0, -0x8_dce6);           /* call 0x100763a0 */
            ii(0x1010_4086, 5); call(0x1008_a998, -0x7_96f3);           /* call 0x1008a998 */
            ii(0x1010_408b, 2); jmp(0x1010_4059, -0x34); goto l_0x1010_4059; /* jmp 0x10104059 */
        l_0x1010_408d:
            ii(0x1010_408d, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_4091, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1010_4094, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_4097, 3); mov(eax, memd[ds, eax + 0x2]);          /* mov eax, [eax+0x2] */
            ii(0x1010_409a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_409c, 5); call(0x1013_a6f4, 0x3_6653);            /* call 0x1013a6f4 */
            ii(0x1010_40a1, 2); jmp(0x1010_4028, -0x7b); goto l_0x1010_4028; /* jmp 0x10104028 */
        l_0x1010_40a3:
            ii(0x1010_40a3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_40a5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_40a8, 5); call(0x1007_5f6c, -0x8_e141);           /* call 0x10075f6c */
            ii(0x1010_40ad, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_40af, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_40b0, 1); pop(edi);                               /* pop edi */
            ii(0x1010_40b1, 1); pop(esi);                               /* pop esi */
            ii(0x1010_40b2, 1); pop(edx);                               /* pop edx */
            ii(0x1010_40b3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_40b4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_40b5, 1); ret();                                  /* ret */
        }
    }
}
