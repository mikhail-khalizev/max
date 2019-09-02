using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_a568-2e8f0b06")]
        public void /* sys */ Method_1016_a568()
        {
            ii(0x1016_a568, 1); push(ebx);                              /* push ebx */
            ii(0x1016_a569, 1); push(ecx);                              /* push ecx */
            ii(0x1016_a56a, 1); push(edx);                              /* push edx */
            ii(0x1016_a56b, 1); push(esi);                              /* push esi */
            ii(0x1016_a56c, 1); push(ebp);                              /* push ebp */
            ii(0x1016_a56d, 6); mov(esi, memd[ds, 0x101c_f964]);        /* mov esi, [0x101cf964] */
            ii(0x1016_a573, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_a575, 3); mov(eax, memd[ds, esi + 12]);           /* mov eax, [esi+0xc] */
            ii(0x1016_a578, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_a57a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_a57c, 2); jmp(0x1016_a58a, 0xc); goto l_0x1016_a58a; /* jmp 0x1016a58a */
        l_0x1016_a57e:
            ii(0x1016_a57e, 2); mov(ebp, memd[ds, eax]);                /* mov ebp, [eax] */
            ii(0x1016_a580, 2); cmp(ebx, ebp);                          /* cmp ebx, ebp */
            ii(0x1016_a582, 2); if(jge(0x1016_a586, 2)) goto l_0x1016_a586; /* jge 0x1016a586 */
            ii(0x1016_a584, 2); mov(ebx, ebp);                          /* mov ebx, ebp */
        l_0x1016_a586:
            ii(0x1016_a586, 3); add(eax, 8);                            /* add eax, 0x8 */
            ii(0x1016_a589, 1); inc(edx);                               /* inc edx */
        l_0x1016_a58a:
            ii(0x1016_a58a, 2); cmp(edx, memd[ds, esi]);                /* cmp edx, [esi] */
            ii(0x1016_a58c, 2); if(jl(0x1016_a57e, -0x10)) goto l_0x1016_a57e; /* jl 0x1016a57e */
            ii(0x1016_a58e, 3); mov(eax, memd[ds, esi + 8]);            /* mov eax, [esi+0x8] */
            ii(0x1016_a591, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_a593, 6); mov(memd[ds, 0x101c_f964], esi);        /* mov [0x101cf964], esi */
            ii(0x1016_a599, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_a59a, 1); pop(esi);                               /* pop esi */
            ii(0x1016_a59b, 1); pop(edx);                               /* pop edx */
            ii(0x1016_a59c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_a59d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_a59e, 1); ret();                                  /* ret */
        }
    }
}
