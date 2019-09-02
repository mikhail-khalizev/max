using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_a5a0-4c37fab5")]
        public void /* sys */ Method_1016_a5a0()
        {
            ii(0x1016_a5a0, 1); push(esi);                              /* push esi */
            ii(0x1016_a5a1, 1); push(edi);                              /* push edi */
            ii(0x1016_a5a2, 1); push(ebp);                              /* push ebp */
            ii(0x1016_a5a3, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_a5a6, 4); mov(memd[ss, esp + 4], eax);            /* mov [esp+0x4], eax */
            ii(0x1016_a5aa, 3); mov(memd[ss, esp], edx);                /* mov [esp], edx */
            ii(0x1016_a5ad, 2); mov(ebp, ebx);                          /* mov ebp, ebx */
            ii(0x1016_a5af, 4); mov(ebx, memd[ss, esp + 0x20]);         /* mov ebx, [esp+0x20] */
            ii(0x1016_a5b3, 2); sub(ebx, ebp);                          /* sub ebx, ebp */
            ii(0x1016_a5b5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_a5b7, 1); cdq();                                  /* cdq */
            ii(0x1016_a5b8, 2); xor(eax, edx);                          /* xor eax, edx */
            ii(0x1016_a5ba, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_a5bc, 7); lea(esi, memd[ds, eax * 2]);            /* lea esi, [eax*2] */
            ii(0x1016_a5c3, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_a5c5, 2); if(jge(0x1016_a5ce, 7)) goto l_0x1016_a5ce; /* jge 0x1016a5ce */
            ii(0x1016_a5c7, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_a5cc, 2); jmp(0x1016_a5d6, 8); goto l_0x1016_a5d6; /* jmp 0x1016a5d6 */
        l_0x1016_a5ce:
            ii(0x1016_a5ce, 3); setg(al);                               /* setg al */
            ii(0x1016_a5d1, 5); and(eax, 0xff);                         /* and eax, 0xff */
        l_0x1016_a5d6:
            ii(0x1016_a5d6, 4); mov(ebx, memd[ss, esp + 0x24]);         /* mov ebx, [esp+0x24] */
            ii(0x1016_a5da, 2); sub(ebx, ecx);                          /* sub ebx, ecx */
            ii(0x1016_a5dc, 4); mov(memd[ss, esp + 0xc], eax);          /* mov [esp+0xc], eax */
            ii(0x1016_a5e0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_a5e2, 1); cdq();                                  /* cdq */
            ii(0x1016_a5e3, 2); xor(eax, edx);                          /* xor eax, edx */
            ii(0x1016_a5e5, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_a5e7, 7); lea(edi, memd[ds, eax * 2]);            /* lea edi, [eax*2] */
            ii(0x1016_a5ee, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_a5f0, 2); if(jge(0x1016_a5f9, 7)) goto l_0x1016_a5f9; /* jge 0x1016a5f9 */
            ii(0x1016_a5f2, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_a5f7, 2); jmp(0x1016_a601, 8); goto l_0x1016_a601; /* jmp 0x1016a601 */
        l_0x1016_a5f9:
            ii(0x1016_a5f9, 3); setg(al);                               /* setg al */
            ii(0x1016_a5fc, 5); and(eax, 0xff);                         /* and eax, 0xff */
        l_0x1016_a601:
            ii(0x1016_a601, 4); mov(memd[ss, esp + 8], eax);            /* mov [esp+0x8], eax */
            ii(0x1016_a605, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1016_a607, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_a609, 2); cmp(esi, edi);                          /* cmp esi, edi */
            ii(0x1016_a60b, 2); if(jle(0x1016_a648, 0x3b)) goto l_0x1016_a648; /* jle 0x1016a648 */
            ii(0x1016_a60d, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1016_a60f, 2); mov(ecx, edi);                          /* mov ecx, edi */
            ii(0x1016_a611, 2); sar(ebx, 1);                            /* sar ebx, 1 */
            ii(0x1016_a613, 2); sub(ecx, ebx);                          /* sub ecx, ebx */
            ii(0x1016_a615, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
        l_0x1016_a617:
            ii(0x1016_a617, 3); mov(ebp, memd[ss, esp]);                /* mov ebp, [esp] */
            ii(0x1016_a61a, 3); imul(ebp, edx);                         /* imul ebp, edx */
            ii(0x1016_a61d, 4); mov(ecx, memd[ss, esp + 4]);            /* mov ecx, [esp+0x4] */
            ii(0x1016_a621, 2); add(ebp, eax);                          /* add ebp, eax */
            ii(0x1016_a623, 2); add(ebp, ecx);                          /* add ebp, ecx */
            ii(0x1016_a625, 4); mov(cl, memb[ss, esp + 0x28]);          /* mov cl, [esp+0x28] */
            ii(0x1016_a629, 3); mov(memb[ss, ebp], cl);                 /* mov [ebp], cl */
            ii(0x1016_a62c, 4); cmp(eax, memd[ss, esp + 0x20]);         /* cmp eax, [esp+0x20] */
            ii(0x1016_a630, 2); if(jz(0x1016_a683, 0x51)) goto l_0x1016_a683; /* jz 0x1016a683 */
            ii(0x1016_a632, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_a634, 2); if(jl(0x1016_a63e, 8)) goto l_0x1016_a63e; /* jl 0x1016a63e */
            ii(0x1016_a636, 4); mov(ecx, memd[ss, esp + 8]);            /* mov ecx, [esp+0x8] */
            ii(0x1016_a63a, 2); sub(ebx, esi);                          /* sub ebx, esi */
            ii(0x1016_a63c, 2); add(edx, ecx);                          /* add edx, ecx */
        l_0x1016_a63e:
            ii(0x1016_a63e, 4); mov(ebp, memd[ss, esp + 0xc]);          /* mov ebp, [esp+0xc] */
            ii(0x1016_a642, 2); add(ebx, edi);                          /* add ebx, edi */
            ii(0x1016_a644, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1016_a646, 2); jmp(0x1016_a617, -0x31); goto l_0x1016_a617; /* jmp 0x1016a617 */
        l_0x1016_a648:
            ii(0x1016_a648, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_a64a, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1016_a64c, 2); sar(ebx, 1);                            /* sar ebx, 1 */
            ii(0x1016_a64e, 2); sub(ecx, ebx);                          /* sub ecx, ebx */
            ii(0x1016_a650, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
        l_0x1016_a652:
            ii(0x1016_a652, 3); mov(ebp, memd[ss, esp]);                /* mov ebp, [esp] */
            ii(0x1016_a655, 3); imul(ebp, edx);                         /* imul ebp, edx */
            ii(0x1016_a658, 4); mov(ecx, memd[ss, esp + 4]);            /* mov ecx, [esp+0x4] */
            ii(0x1016_a65c, 2); add(ebp, eax);                          /* add ebp, eax */
            ii(0x1016_a65e, 2); add(ebp, ecx);                          /* add ebp, ecx */
            ii(0x1016_a660, 4); mov(cl, memb[ss, esp + 0x28]);          /* mov cl, [esp+0x28] */
            ii(0x1016_a664, 3); mov(memb[ss, ebp], cl);                 /* mov [ebp], cl */
            ii(0x1016_a667, 4); cmp(edx, memd[ss, esp + 0x24]);         /* cmp edx, [esp+0x24] */
            ii(0x1016_a66b, 2); if(jz(0x1016_a683, 0x16)) goto l_0x1016_a683; /* jz 0x1016a683 */
            ii(0x1016_a66d, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_a66f, 2); if(jl(0x1016_a679, 8)) goto l_0x1016_a679; /* jl 0x1016a679 */
            ii(0x1016_a671, 4); mov(ecx, memd[ss, esp + 0xc]);          /* mov ecx, [esp+0xc] */
            ii(0x1016_a675, 2); sub(ebx, edi);                          /* sub ebx, edi */
            ii(0x1016_a677, 2); add(eax, ecx);                          /* add eax, ecx */
        l_0x1016_a679:
            ii(0x1016_a679, 4); mov(ebp, memd[ss, esp + 8]);            /* mov ebp, [esp+0x8] */
            ii(0x1016_a67d, 2); add(ebx, esi);                          /* add ebx, esi */
            ii(0x1016_a67f, 2); add(edx, ebp);                          /* add edx, ebp */
            ii(0x1016_a681, 2); jmp(0x1016_a652, -0x31); goto l_0x1016_a652; /* jmp 0x1016a652 */
        l_0x1016_a683:
            ii(0x1016_a683, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_a686, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_a687, 1); pop(edi);                               /* pop edi */
            ii(0x1016_a688, 1); pop(esi);                               /* pop esi */
            ii(0x1016_a689, 3); ret(0xc);                               /* ret 0xc */
        }
    }
}
