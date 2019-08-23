using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_b032-7bddcfff")]
        public void Method_1007_b032()
        {
            ii(0x1007_b032, 5); push(0x30);                             /* push 0x30 */
            ii(0x1007_b037, 5); call(Definitions.sys_check_available_stack_size, 0xe_ad16); /* call 0x10165d52 */
            ii(0x1007_b03c, 1); push(ebx);                              /* push ebx */
            ii(0x1007_b03d, 1); push(ecx);                              /* push ecx */
            ii(0x1007_b03e, 1); push(edx);                              /* push edx */
            ii(0x1007_b03f, 1); push(esi);                              /* push esi */
            ii(0x1007_b040, 1); push(edi);                              /* push edi */
            ii(0x1007_b041, 1); push(ebp);                              /* push ebp */
            ii(0x1007_b042, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_b044, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_b04a, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_b04d, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_b054, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b057, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1007_b05a, 5); call(0x1007_6338, -0x4d27);             /* call 0x10076338 */
            ii(0x1007_b05f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_b061, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_b064, 5); call(0x1007_64b8, -0x4bb1);             /* call 0x100764b8 */
            ii(0x1007_b069, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b06c, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_b06f, 5); call(0x1008_afb4, 0xff40);              /* call 0x1008afb4 */
            ii(0x1007_b074, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_b077, 2); jmp(0x1007_b081, 0x8); goto l_0x1007_b081; /* jmp 0x1007b081 */
        l_0x1007_b079:
            ii(0x1007_b079, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_b07c, 5); call(0x1007_6bf8, -0x4489);             /* call 0x10076bf8 */
        l_0x1007_b081:
            ii(0x1007_b081, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_b083, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_b086, 5); call(0x1013_ad71, 0xb_fce6);            /* call 0x1013ad71 */
            ii(0x1007_b08b, 2); test(al, al);                           /* test al, al */
            ii(0x1007_b08d, 2); if(jz(0x1007_b0c9, 0x3a)) goto l_0x1007_b0c9; /* jz 0x1007b0c9 */
            ii(0x1007_b08f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_b092, 5); call(0x1007_63d4, -0x4cc3);             /* call 0x100763d4 */
            ii(0x1007_b097, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_b099, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_b09c, 5); call(0x1008_6804, 0xb763);              /* call 0x10086804 */
            ii(0x1007_b0a1, 2); test(al, al);                           /* test al, al */
            ii(0x1007_b0a3, 2); if(jz(0x1007_b0c7, 0x22)) goto l_0x1007_b0c7; /* jz 0x1007b0c7 */
            ii(0x1007_b0a5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b0a8, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_b0ab, 5); call(0x1008_a228, 0xf178);              /* call 0x1008a228 */
            ii(0x1007_b0b0, 5); call(0x1008_a370, 0xf2bb);              /* call 0x1008a370 */
            ii(0x1007_b0b5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_b0b7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_b0ba, 5); call(0x1007_63d4, -0x4ceb);             /* call 0x100763d4 */
            ii(0x1007_b0bf, 5); call(0x1007_af7a, -0x14a);              /* call 0x1007af7a */
            ii(0x1007_b0c4, 3); add(memd[ss, ebp - 0xc], eax);          /* add [ebp-0xc], eax */
        l_0x1007_b0c7:
            ii(0x1007_b0c7, 2); jmp(0x1007_b079, -0x50); goto l_0x1007_b079; /* jmp 0x1007b079 */
        l_0x1007_b0c9:
            ii(0x1007_b0c9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_b0cc, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_b0cf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_b0d1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_b0d4, 5); call(0x1007_5f6c, -0x516d);             /* call 0x10075f6c */
            ii(0x1007_b0d9, 2); jmp(0x1007_b0e5, 0xa); goto l_0x1007_b0e5; /* jmp 0x1007b0e5 */
        //  ii(0x1007_b0db, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_b0dd, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //  ii(0x1007_b0e0, 5); call(0x1007_5f6c, -0x5179);             /* call 0x10075f6c */
        l_0x1007_b0e5:
            ii(0x1007_b0e5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_b0e8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_b0ea, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_b0eb, 1); pop(edi);                               /* pop edi */
            ii(0x1007_b0ec, 1); pop(esi);                               /* pop esi */
            ii(0x1007_b0ed, 1); pop(edx);                               /* pop edx */
            ii(0x1007_b0ee, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_b0ef, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_b0f0, 1); ret();                                  /* ret */
        }
    }
}
