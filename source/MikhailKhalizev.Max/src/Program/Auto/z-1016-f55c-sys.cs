using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_f55c-18b35928")]
        public void /* sys */ Method_1016_f55c()
        {
            ii(0x1016_f55c, 1); push(ebx);                              /* push ebx */
            ii(0x1016_f55d, 1); push(ecx);                              /* push ecx */
            ii(0x1016_f55e, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_f561, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_f563, 5); call(/* sys */ 0x1016_efa8, -0x5c0);    /* call 0x1016efa8 */
            ii(0x1016_f568, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1016_f56b, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_f56e, 2); if(jz(0x1016_f575, 0x5)) goto l_0x1016_f575; /* jz 0x1016f575 */
            ii(0x1016_f570, 3); mov(cl, memb[ss, esp]);                 /* mov cl, [esp] */
            ii(0x1016_f573, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_f575:
            ii(0x1016_f575, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_f578, 2); if(jz(0x1016_f5b0, 0x36)) goto l_0x1016_f5b0; /* jz 0x1016f5b0 */
            ii(0x1016_f57a, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_f57c, 2); mov(al, cl);                            /* mov al, cl */
            ii(0x1016_f57e, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1016_f581, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_f583, 5); call(/* sys */ 0x1016_efa8, -0x5e0);    /* call 0x1016efa8 */
            ii(0x1016_f588, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_f58a, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_f58d, 2); if(jz(0x1016_f593, 0x4)) goto l_0x1016_f593; /* jz 0x1016f593 */
            ii(0x1016_f58f, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_f591, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_f593:
            ii(0x1016_f593, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_f596, 2); if(jz(0x1016_f5b0, 0x18)) goto l_0x1016_f5b0; /* jz 0x1016f5b0 */
            ii(0x1016_f598, 3); mov(bx, memw[ds, edx]);                 /* mov bx, [edx] */
            ii(0x1016_f59b, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_f59d, 3); shl(ebx, 0x8);                          /* shl ebx, 0x8 */
            ii(0x1016_f5a0, 2); mov(al, cl);                            /* mov al, cl */
            ii(0x1016_f5a2, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1016_f5a4, 3); mov(memw[ds, edx], bx);                 /* mov [edx], bx */
            ii(0x1016_f5a7, 2); or(ecx, eax);                           /* or ecx, eax */
            ii(0x1016_f5a9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_f5ab, 3); mov(memw[ds, edx], cx);                 /* mov [edx], cx */
            ii(0x1016_f5ae, 2); jmp(0x1016_f5b5, 0x5); goto l_0x1016_f5b5; /* jmp 0x1016f5b5 */
        l_0x1016_f5b0:
            ii(0x1016_f5b0, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
        l_0x1016_f5b5:
            ii(0x1016_f5b5, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_f5b8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_f5b9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_f5ba, 1); ret();                                  /* ret */
        }
    }
}
