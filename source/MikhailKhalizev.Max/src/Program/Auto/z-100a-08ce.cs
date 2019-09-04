using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_08ce-d6c3e076")]
        public void Method_100a_08ce()
        {
            ii(0x100a_08ce, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100a_08d3, 5); call(Definitions.sys_check_available_stack_size, 0xc_547a); /* call 0x10165d52 */
            ii(0x100a_08d8, 1); push(ebx);                              /* push ebx */
            ii(0x100a_08d9, 1); push(ecx);                              /* push ecx */
            ii(0x100a_08da, 1); push(edx);                              /* push edx */
            ii(0x100a_08db, 1); push(esi);                              /* push esi */
            ii(0x100a_08dc, 1); push(edi);                              /* push edi */
            ii(0x100a_08dd, 1); push(ebp);                              /* push ebp */
            ii(0x100a_08de, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_08e0, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_08e6, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_08e9, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x100a_08ed, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_08f0, 5); call(0x1007_64fc, -0x2_a3f9);           /* call 0x100764fc */
            ii(0x100a_08f5, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_08f8, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x100a_08fc, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_0901, 5); call(0x1007_6338, -0x2_a5ce);           /* call 0x10076338 */
            ii(0x100a_0906, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_0908, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_090b, 5); call(0x1007_643c, -0x2_a4d4);           /* call 0x1007643c */
            ii(0x100a_0910, 2); jmp(0x100a_091a, 8); goto l_0x100a_091a; /* jmp 0x100a091a */
        l_0x100a_0912:
            ii(0x100a_0912, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_0915, 5); call(0x1007_6bf8, -0x2_9d22);           /* call 0x10076bf8 */
        l_0x100a_091a:
            ii(0x100a_091a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_091c, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_091f, 5); call(0x1013_ad71, 0x9_a44d);            /* call 0x1013ad71 */
            ii(0x100a_0924, 2); test(al, al);                           /* test al, al */
            ii(0x100a_0926, 2); if(jz(0x100a_0953, 0x2b)) goto l_0x100a_0953; /* jz 0x100a0953 */
            ii(0x100a_0928, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_092b, 3); add(edx, 0x44);                         /* add edx, 0x44 */
            ii(0x100a_092e, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_0931, 5); call(0x1007_6408, -0x2_a52e);           /* call 0x10076408 */
            ii(0x100a_0936, 5); call(0x1008_b4b4, -0x1_5487);           /* call 0x1008b4b4 */
            ii(0x100a_093b, 2); test(al, al);                           /* test al, al */
            ii(0x100a_093d, 2); if(jz(0x100a_0951, 0x12)) goto l_0x100a_0951; /* jz 0x100a0951 */
            ii(0x100a_093f, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_0942, 5); call(0x1007_6408, -0x2_a53f);           /* call 0x10076408 */
            ii(0x100a_0947, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_0949, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_094c, 5); call(0x100a_0833, -0x11e);              /* call 0x100a0833 */
        l_0x100a_0951:
            ii(0x100a_0951, 2); jmp(0x100a_0912, -0x41); goto l_0x100a_0912; /* jmp 0x100a0912 */
        l_0x100a_0953:
            ii(0x100a_0953, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_0955, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_0958, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_095b, 5); call(0x1013_ad71, 0x9_a411);            /* call 0x1013ad71 */
            ii(0x100a_0960, 2); test(al, al);                           /* test al, al */
            ii(0x100a_0962, 2); if(jz(0x100a_0979, 0x15)) goto l_0x100a_0979; /* jz 0x100a0979 */
            ii(0x100a_0964, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_0967, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_096a, 5); call(0x1007_6600, -0x2_a36f);           /* call 0x10076600 */
            ii(0x100a_096f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_0971, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_0974, 5); call(0x100a_0833, -0x146);              /* call 0x100a0833 */
        l_0x100a_0979:
            ii(0x100a_0979, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_097b, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100a_097e, 5); call(0x1007_5f6c, -0x2_aa17);           /* call 0x10075f6c */
            ii(0x100a_0983, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_0985, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_0986, 1); pop(edi);                               /* pop edi */
            ii(0x100a_0987, 1); pop(esi);                               /* pop esi */
            ii(0x100a_0988, 1); pop(edx);                               /* pop edx */
            ii(0x100a_0989, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_098a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_098b, 1); ret();                                  /* ret */
        }
    }
}
