using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_60dd-b7c4546e")]
        public void Method_1008_60dd()
        {
            ii(0x1008_60dd, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1008_60e2, 5); call(Definitions.sys_check_available_stack_size, 0xd_fc6b); /* call 0x10165d52 */
            ii(0x1008_60e7, 1); push(ebx);                              /* push ebx */
            ii(0x1008_60e8, 1); push(ecx);                              /* push ecx */
            ii(0x1008_60e9, 1); push(edx);                              /* push edx */
            ii(0x1008_60ea, 1); push(esi);                              /* push esi */
            ii(0x1008_60eb, 1); push(edi);                              /* push edi */
            ii(0x1008_60ec, 1); push(ebp);                              /* push ebp */
            ii(0x1008_60ed, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_60ef, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1008_60f5, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_60f8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_60fb, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_60fe, 5); call(0x1008_9d08, 0x3c05);              /* call 0x10089d08 */
            ii(0x1008_6103, 3); lea(ebx, memd[ss, ebp - 32]);           /* lea ebx, [ebp-0x20] */
            ii(0x1008_6106, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6108, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_610a, 5); call(0x1008_9be4, 0x3ad5);              /* call 0x10089be4 */
            ii(0x1008_610f, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x1008_6113, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1008_6116, 5); call(0x1007_64fc, -0xfc1f);             /* call 0x100764fc */
            ii(0x1008_611b, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1008_611e, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x1008_6122, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x1008_6129, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_612b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_612e, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_6131, 5); call(0x1013_ad71, 0xb_4c3b);            /* call 0x1013ad71 */
            ii(0x1008_6136, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6138, 2); if(jz(0x1008_6151, 0x17)) goto l_0x1008_6151; /* jz 0x10086151 */
            ii(0x1008_613a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_613d, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_6140, 5); call(0x1007_6574, -0xfbd1);             /* call 0x10076574 */
            ii(0x1008_6145, 5); call(0x1007_623c, -0xff0e);             /* call 0x1007623c */
            ii(0x1008_614a, 4); mov(ax, memw[ds, eax + 23]);            /* mov ax, [eax+0x17] */
            ii(0x1008_614e, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
        l_0x1008_6151:
            ii(0x1008_6151, 2); jmp(0x1008_615b, 8); goto l_0x1008_615b; /* jmp 0x1008615b */
        l_0x1008_6153:
            ii(0x1008_6153, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1008_6156, 5); call(0x1007_6bf8, -0xf563);             /* call 0x10076bf8 */
        l_0x1008_615b:
            ii(0x1008_615b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_615d, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1008_6160, 5); call(0x1013_ad71, 0xb_4c0c);            /* call 0x1013ad71 */
            ii(0x1008_6165, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6167, 2); if(jz(0x1008_61c3, 0x5a)) goto l_0x1008_61c3; /* jz 0x100861c3 */
            ii(0x1008_6169, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1008_616c, 5); call(0x1008_9acc, 0x395b);              /* call 0x10089acc */
            ii(0x1008_6171, 5); call(0x1008_9fc4, 0x3e4e);              /* call 0x10089fc4 */
            ii(0x1008_6176, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6178, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1008_617b, 5); call(0x1007_643c, -0xfd44);             /* call 0x1007643c */
            ii(0x1008_6180, 2); jmp(0x1008_618a, 8); goto l_0x1008_618a; /* jmp 0x1008618a */
        l_0x1008_6182:
            ii(0x1008_6182, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1008_6185, 5); call(0x1007_6bf8, -0xf592);             /* call 0x10076bf8 */
        l_0x1008_618a:
            ii(0x1008_618a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_618c, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1008_618f, 5); call(0x1013_ad71, 0xb_4bdd);            /* call 0x1013ad71 */
            ii(0x1008_6194, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6196, 2); if(jz(0x1008_61c1, 0x29)) goto l_0x1008_61c1; /* jz 0x100861c1 */
            ii(0x1008_6198, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1008_619b, 5); call(0x1007_63a0, -0xfe00);             /* call 0x100763a0 */
            ii(0x1008_61a0, 5); call(0x1007_623c, -0xff69);             /* call 0x1007623c */
            ii(0x1008_61a5, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1008_61a8, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1008_61ab, 4); mov(ax, memw[ds, eax + 23]);            /* mov ax, [eax+0x17] */
            ii(0x1008_61af, 4); cmp(ax, memw[ss, ebp - 16]);            /* cmp ax, [ebp-0x10] */
            ii(0x1008_61b3, 2); if(jle(0x1008_61bf, 0xa)) goto l_0x1008_61bf; /* jle 0x100861bf */
            ii(0x1008_61b5, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1008_61b8, 4); mov(ax, memw[ds, eax + 23]);            /* mov ax, [eax+0x17] */
            ii(0x1008_61bc, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
        l_0x1008_61bf:
            ii(0x1008_61bf, 2); jmp(0x1008_6182, -0x3f); goto l_0x1008_6182; /* jmp 0x10086182 */
        l_0x1008_61c1:
            ii(0x1008_61c1, 2); jmp(0x1008_6153, -0x70); goto l_0x1008_6153; /* jmp 0x10086153 */
        l_0x1008_61c3:
            ii(0x1008_61c3, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1008_61c6, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_61c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_61cb, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1008_61ce, 5); call(0x1007_5f6c, -0x1_0267);           /* call 0x10075f6c */
            ii(0x1008_61d3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_61d5, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x1008_61d8, 5); call(0x1008_9044, 0x2e67);              /* call 0x10089044 */
            ii(0x1008_61dd, 2); jmp(0x1008_61f3, 0x14); goto l_0x1008_61f3; /* jmp 0x100861f3 */
        //  ii(0x1008_61df, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_61e1, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
        //  ii(0x1008_61e4, 5); call(0x1007_5f6c, -0x1_027d);           /* call 0x10075f6c */
        //  ii(0x1008_61e9, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_61eb, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
        //  ii(0x1008_61ee, 5); call(0x1008_9044, 0x2e51);              /* call 0x10089044 */
        l_0x1008_61f3:
            ii(0x1008_61f3, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_61f6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_61f8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_61f9, 1); pop(edi);                               /* pop edi */
            ii(0x1008_61fa, 1); pop(esi);                               /* pop esi */
            ii(0x1008_61fb, 1); pop(edx);                               /* pop edx */
            ii(0x1008_61fc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_61fd, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_61fe, 1); ret();                                  /* ret */
        }
    }
}
