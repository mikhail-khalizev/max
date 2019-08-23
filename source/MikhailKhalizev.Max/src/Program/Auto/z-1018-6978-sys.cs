using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_6978-99dd9a12")]
        public void /* sys */ Method_1018_6978()
        {
            ii(0x1018_6978, 1); push(esi);                              /* push esi */
            ii(0x1018_6979, 1); push(edi);                              /* push edi */
            ii(0x1018_697a, 1); push(ecx);                              /* push ecx */
            ii(0x1018_697b, 1); push(ds);                               /* push ds */
            ii(0x1018_697c, 2); mov(ds, edx);                           /* mov ds, edx */
            ii(0x1018_697e, 2); or(eax, eax);                           /* or eax, eax */
            ii(0x1018_6980, 2); if(jz(0x1018_69c7, 0x45)) goto l_0x1018_69c7; /* jz 0x101869c7 */
            ii(0x1018_6982, 3); add(eax, 0xb);                          /* add eax, 0xb */
            ii(0x1018_6985, 2); if(jb(0x1018_69c7, 0x40)) goto l_0x1018_69c7; /* jb 0x101869c7 */
            ii(0x1018_6987, 2); and(al, 0xf8);                          /* and al, 0xf8 */
            ii(0x1018_6989, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1018_698e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1018_6990, 1); cmc();                                  /* cmc */
            ii(0x1018_6991, 2); sbb(ecx, ecx);                          /* sbb ecx, ecx */
            ii(0x1018_6993, 2); and(eax, ecx);                          /* and eax, ecx */
            ii(0x1018_6995, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_6997, 3); cmp(eax, memd[ds, ebx + 0x14]);         /* cmp eax, [ebx+0x14] */
            ii(0x1018_699a, 2); if(ja(0x1018_69c7, 0x2b)) goto l_0x1018_69c7; /* ja 0x101869c7 */
            ii(0x1018_699c, 3); mov(esi, memd[ds, ebx + 0xc]);          /* mov esi, [ebx+0xc] */
            ii(0x1018_699f, 3); mov(edi, memd[ds, ebx + 0x10]);         /* mov edi, [ebx+0x10] */
            ii(0x1018_69a2, 2); cmp(eax, edi);                          /* cmp eax, edi */
            ii(0x1018_69a4, 2); if(ja(0x1018_69ab, 0x5)) goto l_0x1018_69ab; /* ja 0x101869ab */
            ii(0x1018_69a6, 3); mov(esi, memd[ds, ebx + 0x28]);         /* mov esi, [ebx+0x28] */
            ii(0x1018_69a9, 2); sub(edi, edi);                          /* sub edi, edi */
        l_0x1018_69ab:
            ii(0x1018_69ab, 2); mov(edx, memd[ds, esi]);                /* mov edx, [esi] */
            ii(0x1018_69ad, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_69af, 2); if(jbe(0x1018_69cb, 0x1a)) goto l_0x1018_69cb; /* jbe 0x101869cb */
            ii(0x1018_69b1, 2); sub(edi, edx);                          /* sub edi, edx */
            ii(0x1018_69b3, 1); cmc();                                  /* cmc */
            ii(0x1018_69b4, 2); sbb(ecx, ecx);                          /* sbb ecx, ecx */
            ii(0x1018_69b6, 2); and(edi, ecx);                          /* and edi, ecx */
            ii(0x1018_69b8, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_69ba, 3); lea(edx, memd[ds, ebx + 0x20]);         /* lea edx, [ebx+0x20] */
            ii(0x1018_69bd, 3); mov(esi, memd[ds, esi + 0x8]);          /* mov esi, [esi+0x8] */
            ii(0x1018_69c0, 2); cmp(esi, edx);                          /* cmp esi, edx */
            ii(0x1018_69c2, 2); if(jnz(0x1018_69ab, -0x19)) goto l_0x1018_69ab; /* jnz 0x101869ab */
            ii(0x1018_69c4, 3); mov(memd[ds, ebx + 0x14], edi);         /* mov [ebx+0x14], edi */
        l_0x1018_69c7:
            ii(0x1018_69c7, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1018_69c9, 2); jmp(0x1018_6a16, 0x4b); goto l_0x1018_6a16; /* jmp 0x10186a16 */
        l_0x1018_69cb:
            ii(0x1018_69cb, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1018_69cd, 3); mov(memd[ds, ebx + 0x10], edi);         /* mov [ebx+0x10], edi */
            ii(0x1018_69d0, 3); inc(memd[ds, ebx + 0x18]);              /* inc dword [ebx+0x18] */
            ii(0x1018_69d3, 3); mov(ecx, memd[ds, esi + 0x8]);          /* mov ecx, [esi+0x8] */
            ii(0x1018_69d6, 3); cmp(edx, 0x10);                         /* cmp edx, 0x10 */
            ii(0x1018_69d9, 2); if(jb(0x1018_69f9, 0x1e)) goto l_0x1018_69f9; /* jb 0x101869f9 */
            ii(0x1018_69db, 2); mov(edi, esi);                          /* mov edi, esi */
            ii(0x1018_69dd, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1018_69df, 3); mov(memd[ds, ebx + 0xc], edi);          /* mov [ebx+0xc], edi */
            ii(0x1018_69e2, 2); mov(memd[ds, edi], edx);                /* mov [edi], edx */
            ii(0x1018_69e4, 2); mov(memd[ds, esi], eax);                /* mov [esi], eax */
            ii(0x1018_69e6, 3); mov(ebx, memd[ds, esi + 0x4]);          /* mov ebx, [esi+0x4] */
            ii(0x1018_69e9, 3); mov(memd[ds, edi + 0x4], ebx);          /* mov [edi+0x4], ebx */
            ii(0x1018_69ec, 3); mov(memd[ds, edi + 0x8], ecx);          /* mov [edi+0x8], ecx */
            ii(0x1018_69ef, 3); mov(memd[ds, ebx + 0x8], edi);          /* mov [ebx+0x8], edi */
            ii(0x1018_69f2, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1018_69f4, 3); mov(memd[ds, ebx + 0x4], edi);          /* mov [ebx+0x4], edi */
            ii(0x1018_69f7, 2); jmp(0x1018_6a0e, 0x15); goto l_0x1018_6a0e; /* jmp 0x10186a0e */
        l_0x1018_69f9:
            ii(0x1018_69f9, 3); dec(memd[ds, ebx + 0x1c]);              /* dec dword [ebx+0x1c] */
            ii(0x1018_69fc, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1018_69fe, 2); mov(edi, ecx);                          /* mov edi, ecx */
            ii(0x1018_6a00, 3); mov(esi, memd[ds, esi + 0x4]);          /* mov esi, [esi+0x4] */
            ii(0x1018_6a03, 3); mov(memd[ds, esi + 0x8], edi);          /* mov [esi+0x8], edi */
            ii(0x1018_6a06, 3); mov(memd[ds, edi + 0x4], esi);          /* mov [edi+0x4], esi */
            ii(0x1018_6a09, 3); mov(memd[ds, ebx + 0xc], esi);          /* mov [ebx+0xc], esi */
            ii(0x1018_6a0c, 2); mov(esi, eax);                          /* mov esi, eax */
        l_0x1018_6a0e:
            ii(0x1018_6a0e, 3); or(memd[ds, esi], 0x1);                 /* or dword [esi], 0x1 */
            ii(0x1018_6a11, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1018_6a13, 3); add(eax, 0x4);                          /* add eax, 0x4 */
        l_0x1018_6a16:
            ii(0x1018_6a16, 1); pop(ds);                                /* pop ds */
            ii(0x1018_6a17, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_6a18, 1); pop(edi);                               /* pop edi */
            ii(0x1018_6a19, 1); pop(esi);                               /* pop esi */
            ii(0x1018_6a1a, 1); ret();                                  /* ret */
        }
    }
}
