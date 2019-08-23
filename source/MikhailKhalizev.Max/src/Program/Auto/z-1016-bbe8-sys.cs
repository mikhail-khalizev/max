using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_bbe8-e65cfab9")]
        public void /* sys */ Method_1016_bbe8()
        {
            ii(0x1016_bbe8, 1); push(esi);                              /* push esi */
            ii(0x1016_bbe9, 1); push(edi);                              /* push edi */
            ii(0x1016_bbea, 1); push(ebp);                              /* push ebp */
            ii(0x1016_bbeb, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_bbed, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1016_bbef, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1016_bbf1, 4); mov(ebx, memd[ss, esp + 0x10]);         /* mov ebx, [esp+0x10] */
            ii(0x1016_bbf5, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1016_bbf7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_bbf9, 4); mov(al, memb[ss, esp + 0x1c]);          /* mov al, [esp+0x1c] */
            ii(0x1016_bbfd, 1); push(eax);                              /* push eax */
            ii(0x1016_bbfe, 4); mov(ecx, memd[ss, esp + 0x1c]);         /* mov ecx, [esp+0x1c] */
            ii(0x1016_bc02, 1); push(ecx);                              /* push ecx */
            ii(0x1016_bc03, 4); mov(eax, memd[ss, esp + 0x1c]);         /* mov eax, [esp+0x1c] */
            ii(0x1016_bc07, 1); push(eax);                              /* push eax */
            ii(0x1016_bc08, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_bc0a, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1016_bc0d, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1016_bc10, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1016_bc12, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1016_bc14, 5); call(/* sys */ 0x1016_ba3c, -0x1dd);    /* call 0x1016ba3c */
            ii(0x1016_bc19, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_bc1c, 2); if(jz(0x1016_bc45, 0x27)) goto l_0x1016_bc45; /* jz 0x1016bc45 */
            ii(0x1016_bc1e, 4); mov(eax, memd[ss, esp + 0x20]);         /* mov eax, [esp+0x20] */
            ii(0x1016_bc22, 6); mov(memd[ds, 0x101b_de68], esi);        /* mov [0x101bde68], esi */
            ii(0x1016_bc28, 6); mov(memd[ds, 0x101c_fbf4], ebp);        /* mov [0x101cfbf4], ebp */
            ii(0x1016_bc2e, 5); mov(memd[ds, 0x101c_fbe0], eax);        /* mov [0x101cfbe0], eax */
            ii(0x1016_bc33, 5); mov(eax, /* sys */ 0x1016_bc4c);        /* mov eax, 0x1016bc4c */
            ii(0x1016_bc38, 6); mov(memd[ds, 0x101c_fbe4], edi);        /* mov [0x101cfbe4], edi */
            ii(0x1016_bc3e, 5); call(/* sys */ 0x1016_b3dc, -0x867);    /* call 0x1016b3dc */
            ii(0x1016_bc43, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_bc45:
            ii(0x1016_bc45, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_bc46, 1); pop(edi);                               /* pop edi */
            ii(0x1016_bc47, 1); pop(esi);                               /* pop esi */
            ii(0x1016_bc48, 3); ret(0x14);                              /* ret 0x14 */
        }
    }
}
