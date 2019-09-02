using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_0a4a-dc3b28d9")]
        public void /* sys */ Method_1018_0a4a()
        {
            ii(0x1018_0a4a, 1); push(ecx);                              /* push ecx */
            ii(0x1018_0a4b, 1); push(esi);                              /* push esi */
            ii(0x1018_0a4c, 1); push(edi);                              /* push edi */
            ii(0x1018_0a4d, 1); push(ebp);                              /* push ebp */
            ii(0x1018_0a4e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_0a50, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1018_0a56, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1018_0a59, 3); mov(memd[ss, ebp - 16], edx);           /* mov [ebp-0x10], edx */
            ii(0x1018_0a5c, 3); mov(memd[ss, ebp - 12], ebx);           /* mov [ebp-0xc], ebx */
            ii(0x1018_0a5f, 7); imul(edx, memd[ss, ebp - 20], 0xc0);    /* imul edx, [ebp-0x14], 0xc0 */
            ii(0x1018_0a66, 4); imul(eax, memd[ss, ebp - 16], 6);       /* imul eax, [ebp-0x10], 0x6 */
            ii(0x1018_0a6a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0a6c, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_0a73, 5); movsx(eax, memw[gs, eax + 48]);         /* movsx eax, word [gs:eax+0x30] */
            ii(0x1018_0a78, 3); test(ah, 0x80);                         /* test ah, 0x80 */
            ii(0x1018_0a7b, 2); if(jz(0x1018_0ab7, 0x3a)) goto l_0x1018_0ab7; /* jz 0x10180ab7 */
            ii(0x1018_0a7d, 7); imul(eax, memd[ss, ebp - 20], 0xc0);    /* imul eax, [ebp-0x14], 0xc0 */
            ii(0x1018_0a84, 4); imul(edx, memd[ss, ebp - 16], 6);       /* imul edx, [ebp-0x10], 0x6 */
            ii(0x1018_0a88, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0a8a, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_0a91, 5); movsx(eax, memw[gs, eax + 84]);         /* movsx eax, word [gs:eax+0x54] */
            ii(0x1018_0a96, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1018_0a99, 7); imul(edx, memd[ss, ebp - 20], 0xc0);    /* imul edx, [ebp-0x14], 0xc0 */
            ii(0x1018_0aa0, 4); imul(eax, memd[ss, ebp - 16], 6);       /* imul eax, [ebp-0x10], 0x6 */
            ii(0x1018_0aa4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_0aa6, 7); lgs(edx, memd[ds, edx + 0x1020_b718]);  /* lgs edx, [edx+0x1020b718] */
            ii(0x1018_0aad, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1018_0ab0, 5); mov(memw[gs, edx + 84], ax);            /* mov [gs:edx+0x54], ax */
            ii(0x1018_0ab5, 2); jmp(0x1018_0ac0, 9); goto l_0x1018_0ac0; /* jmp 0x10180ac0 */
        l_0x1018_0ab7:
            ii(0x1018_0ab7, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1018_0abe, 2); jmp(0x1018_0ac6, 6); goto l_0x1018_0ac6; /* jmp 0x10180ac6 */
        l_0x1018_0ac0:
            ii(0x1018_0ac0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1018_0ac3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1018_0ac6:
            ii(0x1018_0ac6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1018_0ac9, 1); leave();                                /* leave */
            ii(0x1018_0aca, 1); pop(edi);                               /* pop edi */
            ii(0x1018_0acb, 1); pop(esi);                               /* pop esi */
            ii(0x1018_0acc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_0acd, 1); ret();                                  /* ret */
        }
    }
}
