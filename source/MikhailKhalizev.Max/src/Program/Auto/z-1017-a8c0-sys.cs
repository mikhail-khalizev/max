using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_a8c0-cac3de")]
        public void /* sys */ Method_1017_a8c0()
        {
            ii(0x1017_a8c0, 1); push(ebp);                              /* push ebp */
            ii(0x1017_a8c1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_a8c3, 1); push(ecx);                              /* push ecx */
            ii(0x1017_a8c4, 1); push(edi);                              /* push edi */
            ii(0x1017_a8c5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_a8c7, 2); if(jge(0x1017_a8d6, 0xd)) goto l_0x1017_a8d6; /* jge 0x1017a8d6 */
            ii(0x1017_a8c9, 5); mov(eax, memd[ds, 0x1020_9cb4]);        /* mov eax, [0x10209cb4] */
            ii(0x1017_a8ce, 6); sub(eax, memd[ds, 0x1020_9cd0]);        /* sub eax, [0x10209cd0] */
            ii(0x1017_a8d4, 2); shr(eax, 1);                            /* shr eax, 1 */
        l_0x1017_a8d6:
            ii(0x1017_a8d6, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_a8d8, 2); if(jge(0x1017_a905, 0x2b)) goto l_0x1017_a905; /* jge 0x1017a905 */
            ii(0x1017_a8da, 7); test(memb[ds, 0x101b_e200], 4);         /* test byte [0x101be200], 0x4 */
            ii(0x1017_a8e1, 2); if(jz(0x1017_a8f7, 0x14)) goto l_0x1017_a8f7; /* jz 0x1017a8f7 */
            ii(0x1017_a8e3, 6); mov(edx, memd[ds, 0x1020_9cf0]);        /* mov edx, [0x10209cf0] */
            ii(0x1017_a8e9, 6); mov(ecx, memd[ds, 0x1020_9cbc]);        /* mov ecx, [0x10209cbc] */
            ii(0x1017_a8ef, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1017_a8f1, 2); sub(ecx, edx);                          /* sub ecx, edx */
            ii(0x1017_a8f3, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1017_a8f5, 2); jmp(0x1017_a903, 0xc); goto l_0x1017_a903; /* jmp 0x1017a903 */
        l_0x1017_a8f7:
            ii(0x1017_a8f7, 6); mov(edx, memd[ds, 0x1020_9cbc]);        /* mov edx, [0x10209cbc] */
            ii(0x1017_a8fd, 6); sub(edx, memd[ds, 0x1020_9cf0]);        /* sub edx, [0x10209cf0] */
        l_0x1017_a903:
            ii(0x1017_a903, 2); shr(edx, 1);                            /* shr edx, 1 */
        l_0x1017_a905:
            ii(0x1017_a905, 7); xor(memb[ds, 0x101b_e208], 1);          /* xor byte [0x101be208], 0x1 */
            ii(0x1017_a90c, 6); mov(ecx, memd[ds, 0x101b_e208]);        /* mov ecx, [0x101be208] */
            ii(0x1017_a912, 2); and(al, 0xfc);                          /* and al, 0xfc */
            ii(0x1017_a914, 7); mov(edi, memd[ds, ecx * 4 + 0x101b_e20c]); /* mov edi, [ecx*4+0x101be20c] */
            ii(0x1017_a91b, 6); mov(ch, memb[ds, 0x101b_e200]);         /* mov ch, [0x101be200] */
            ii(0x1017_a921, 2); add(edx, edi);                          /* add edx, edi */
            ii(0x1017_a923, 3); test(ch, 4);                            /* test ch, 0x4 */
            ii(0x1017_a926, 2); if(jz(0x1017_a92a, 2)) goto l_0x1017_a92a; /* jz 0x1017a92a */
            ii(0x1017_a928, 2); sar(edx, 1);                            /* sar edx, 1 */
        l_0x1017_a92a:
            ii(0x1017_a92a, 6); mov(ecx, memd[ds, 0x1020_9ce0]);        /* mov ecx, [0x10209ce0] */
            ii(0x1017_a930, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1017_a932, 5); mov(eax, memd[ds, 0x1020_9ce4]);        /* mov eax, [0x10209ce4] */
            ii(0x1017_a937, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_a939, 6); mov(edx, memd[ds, 0x1020_9ccc]);        /* mov edx, [0x10209ccc] */
            ii(0x1017_a93f, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_a941, 2); if(jz(0x1017_a984, 0x41)) goto l_0x1017_a984; /* jz 0x1017a984 */
            ii(0x1017_a943, 1); push(eax);                              /* push eax */
            ii(0x1017_a944, 1); push(ecx);                              /* push ecx */
            ii(0x1017_a945, 1); push(ebx);                              /* push ebx */
            ii(0x1017_a946, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_a948, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_a94a, 6); mov(bl, memb[ds, 0x1020_9dd2]);         /* mov bl, [0x10209dd2] */
            ii(0x1017_a950, 5); mov(eax, memd[ds, 0x1020_9cd4]);        /* mov eax, [0x10209cd4] */
            ii(0x1017_a955, 7); lea(ebx, memd[ds, ebx * 8]);            /* lea ebx, [ebx*8] */
            ii(0x1017_a95c, 2); div(ebx);                               /* div ebx */
            ii(0x1017_a95e, 1); push(eax);                              /* push eax */
            ii(0x1017_a95f, 5); mov(eax, memd[ds, 0x1020_9cdc]);        /* mov eax, [0x10209cdc] */
            ii(0x1017_a964, 3); shr(eax, 4);                            /* shr eax, 0x4 */
            ii(0x1017_a967, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_a969, 1); push(eax);                              /* push eax */
            ii(0x1017_a96a, 5); mov(eax, memd[ds, 0x1020_9ce4]);        /* mov eax, [0x10209ce4] */
            ii(0x1017_a96f, 2); div(ebx);                               /* div ebx */
            ii(0x1017_a971, 1); push(eax);                              /* push eax */
            ii(0x1017_a972, 5); mov(eax, memd[ds, 0x1020_9ce0]);        /* mov eax, [0x10209ce0] */
            ii(0x1017_a977, 3); shr(eax, 4);                            /* shr eax, 0x4 */
            ii(0x1017_a97a, 1); push(eax);                              /* push eax */
            ii(0x1017_a97b, 2); push(0);                                /* push 0x0 */
            ii(0x1017_a97d, 5); call(/* sys */ 0x1019_3cae, 0x1_932c);  /* call 0x10193cae */
            ii(0x1017_a982, 2); jmp(0x1017_a9c1, 0x3d); goto l_0x1017_a9c1; /* jmp 0x1017a9c1 */
        l_0x1017_a984:
            ii(0x1017_a984, 1); push(eax);                              /* push eax */
            ii(0x1017_a985, 1); push(ecx);                              /* push ecx */
            ii(0x1017_a986, 1); push(ebx);                              /* push ebx */
            ii(0x1017_a987, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_a989, 6); mov(bl, memb[ds, 0x1020_9dd2]);         /* mov bl, [0x10209dd2] */
            ii(0x1017_a98f, 5); mov(eax, memd[ds, 0x1020_9cd4]);        /* mov eax, [0x10209cd4] */
            ii(0x1017_a994, 7); lea(ebx, memd[ds, ebx * 8]);            /* lea ebx, [ebx*8] */
            ii(0x1017_a99b, 2); div(ebx);                               /* div ebx */
            ii(0x1017_a99d, 1); push(eax);                              /* push eax */
            ii(0x1017_a99e, 5); mov(eax, memd[ds, 0x1020_9cdc]);        /* mov eax, [0x10209cdc] */
            ii(0x1017_a9a3, 3); shr(eax, 3);                            /* shr eax, 0x3 */
            ii(0x1017_a9a6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_a9a8, 1); push(eax);                              /* push eax */
            ii(0x1017_a9a9, 5); mov(eax, memd[ds, 0x1020_9ce4]);        /* mov eax, [0x10209ce4] */
            ii(0x1017_a9ae, 2); div(ebx);                               /* div ebx */
            ii(0x1017_a9b0, 1); push(eax);                              /* push eax */
            ii(0x1017_a9b1, 5); mov(eax, memd[ds, 0x1020_9ce0]);        /* mov eax, [0x10209ce0] */
            ii(0x1017_a9b6, 3); shr(eax, 3);                            /* shr eax, 0x3 */
            ii(0x1017_a9b9, 1); push(eax);                              /* push eax */
            ii(0x1017_a9ba, 2); push(0);                                /* push 0x0 */
            ii(0x1017_a9bc, 5); call(/* sys */ 0x1019_385b, 0x1_8e9a);  /* call 0x1019385b */
        l_0x1017_a9c1:
            ii(0x1017_a9c1, 3); add(esp, 0x20);                         /* add esp, 0x20 */
            ii(0x1017_a9c4, 3); lea(esp, memd[ss, ebp - 8]);            /* lea esp, [ebp-0x8] */
            ii(0x1017_a9c7, 1); pop(edi);                               /* pop edi */
            ii(0x1017_a9c8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_a9c9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_a9ca, 1); ret();                                  /* ret */
        }
    }
}
