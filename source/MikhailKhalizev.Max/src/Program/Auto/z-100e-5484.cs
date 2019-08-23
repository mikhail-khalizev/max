using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_5484-ce59dd48")]
        public void Method_100e_5484()
        {
            ii(0x100e_5484, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_5489, 5); call(Definitions.sys_check_available_stack_size, 0x8_08c4); /* call 0x10165d52 */
            ii(0x100e_548e, 1); push(ebx);                              /* push ebx */
            ii(0x100e_548f, 1); push(ecx);                              /* push ecx */
            ii(0x100e_5490, 1); push(esi);                              /* push esi */
            ii(0x100e_5491, 1); push(edi);                              /* push edi */
            ii(0x100e_5492, 1); push(ebp);                              /* push ebp */
            ii(0x100e_5493, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_5495, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_549b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_549e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_54a1, 5); call(0x1014_82f4, 0x6_2e4e);            /* call 0x101482f4 */
            ii(0x100e_54a6, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_54a9, 3); mov(edi, memd[ss, ebp - 0x8]);          /* mov edi, [ebp-0x8] */
            ii(0x100e_54ac, 3); mov(esi, memd[ss, ebp - 0x4]);          /* mov esi, [ebp-0x4] */
            ii(0x100e_54af, 1); movsd();                                /* movsd */
            ii(0x100e_54b0, 1); movsd();                                /* movsd */
            ii(0x100e_54b1, 1); movsd();                                /* movsd */
            ii(0x100e_54b2, 1); movsd();                                /* movsd */
            ii(0x100e_54b3, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_54b6, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100e_54b8, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_54bb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_54bd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_54c0, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100e_54c6, 6); mov(ebx, memd[ds, 0x101c_38fa]);        /* mov ebx, [0x101c38fa] */
            ii(0x100e_54cc, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_54cf, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_54d2, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x100e_54d4, 3); mov(memd[ds, edx + 0x10], eax);         /* mov [edx+0x10], eax */
            ii(0x100e_54d7, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_54da, 3); mov(edx, memd[ds, edx + 0x4]);          /* mov edx, [edx+0x4] */
            ii(0x100e_54dd, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_54e0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_54e2, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_54e5, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100e_54eb, 6); mov(ebx, memd[ds, 0x101c_38fc]);        /* mov ebx, [0x101c38fc] */
            ii(0x100e_54f1, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_54f4, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_54f7, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x100e_54f9, 3); mov(memd[ds, edx + 0x14], eax);         /* mov [edx+0x14], eax */
            ii(0x100e_54fc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_54ff, 3); mov(edx, memd[ds, eax + 0x8]);          /* mov edx, [eax+0x8] */
            ii(0x100e_5502, 1); dec(edx);                               /* dec edx */
            ii(0x100e_5503, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_5506, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_5508, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_550b, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100e_5511, 6); mov(edx, memd[ds, 0x101c_38fa]);        /* mov edx, [0x101c38fa] */
            ii(0x100e_5517, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_551a, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_551c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_551f, 1); inc(eax);                               /* inc eax */
            ii(0x100e_5520, 3); mov(memd[ds, edx + 0x18], eax);         /* mov [edx+0x18], eax */
            ii(0x100e_5523, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_5526, 3); mov(edx, memd[ds, edx + 0xc]);          /* mov edx, [edx+0xc] */
            ii(0x100e_5529, 1); dec(edx);                               /* dec edx */
            ii(0x100e_552a, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_552d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_552f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_5532, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100e_5538, 6); mov(edx, memd[ds, 0x101c_38fc]);        /* mov edx, [0x101c38fc] */
            ii(0x100e_553e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_5541, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_5543, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_5546, 1); inc(eax);                               /* inc eax */
            ii(0x100e_5547, 3); mov(memd[ds, edx + 0x1c], eax);         /* mov [edx+0x1c], eax */
            ii(0x100e_554a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_554d, 5); call(0x100e_55f8, 0xa6);                /* call 0x100e55f8 */
            ii(0x100e_5552, 2); test(al, al);                           /* test al, al */
            ii(0x100e_5554, 2); if(jz(0x100e_5560, 0xa)) goto l_0x100e_5560; /* jz 0x100e5560 */
            ii(0x100e_5556, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_5559, 5); call(0x100e_59ff, 0x4a1);               /* call 0x100e59ff */
            ii(0x100e_555e, 2); jmp(0x100e_5568, 0x8); goto l_0x100e_5568; /* jmp 0x100e5568 */
        l_0x100e_5560:
            ii(0x100e_5560, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_5563, 5); call(0x100e_5df1, 0x889);               /* call 0x100e5df1 */
        l_0x100e_5568:
            ii(0x100e_5568, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_556b, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x100e_556e, 5); call(0x1013_b325, 0x5_5db2);            /* call 0x1013b325 */
            ii(0x100e_5573, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_5576, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x100e_5579, 5); call(0x1013_b325, 0x5_5da7);            /* call 0x1013b325 */
            ii(0x100e_557e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_5581, 3); add(eax, 0x34);                         /* add eax, 0x34 */
            ii(0x100e_5584, 5); call(0x1013_b325, 0x5_5d9c);            /* call 0x1013b325 */
            ii(0x100e_5589, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_558c, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100e_558f, 5); call(0x1013_b325, 0x5_5d91);            /* call 0x1013b325 */
            ii(0x100e_5594, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_5597, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x100e_559a, 5); call(0x1013_b325, 0x5_5d86);            /* call 0x1013b325 */
            ii(0x100e_559f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_55a2, 3); add(eax, 0x52);                         /* add eax, 0x52 */
            ii(0x100e_55a5, 5); call(0x1013_b325, 0x5_5d7b);            /* call 0x1013b325 */
            ii(0x100e_55aa, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_55ad, 3); add(eax, 0x5c);                         /* add eax, 0x5c */
            ii(0x100e_55b0, 5); call(0x1013_b325, 0x5_5d70);            /* call 0x1013b325 */
            ii(0x100e_55b5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_55b8, 3); add(eax, 0x66);                         /* add eax, 0x66 */
            ii(0x100e_55bb, 5); call(0x1013_b325, 0x5_5d65);            /* call 0x1013b325 */
            ii(0x100e_55c0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_55c3, 3); add(eax, 0x7a);                         /* add eax, 0x7a */
            ii(0x100e_55c6, 5); call(0x1013_b325, 0x5_5d5a);            /* call 0x1013b325 */
            ii(0x100e_55cb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_55ce, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x100e_55d1, 5); call(0x1013_b325, 0x5_5d4f);            /* call 0x1013b325 */
            ii(0x100e_55d6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_55d9, 5); add(eax, 0x8e);                         /* add eax, 0x8e */
            ii(0x100e_55de, 5); call(0x1013_b325, 0x5_5d42);            /* call 0x1013b325 */
            ii(0x100e_55e3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_55e6, 5); add(eax, 0x84);                         /* add eax, 0x84 */
            ii(0x100e_55eb, 5); call(0x1013_b325, 0x5_5d35);            /* call 0x1013b325 */
            ii(0x100e_55f0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_55f2, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_55f3, 1); pop(edi);                               /* pop edi */
            ii(0x100e_55f4, 1); pop(esi);                               /* pop esi */
            ii(0x100e_55f5, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_55f6, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_55f7, 1); ret();                                  /* ret */
        }
    }
}
