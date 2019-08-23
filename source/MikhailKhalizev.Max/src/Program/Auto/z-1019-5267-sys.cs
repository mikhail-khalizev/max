using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5267-dc34794")]
        public void /* sys */ Method_1019_5267()
        {
            ii(0x1019_5267, 1); push(ebp);                              /* push ebp */
            ii(0x1019_5268, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_526a, 1); push(esi);                              /* push esi */
            ii(0x1019_526b, 1); push(edi);                              /* push edi */
            ii(0x1019_526c, 1); push(ebx);                              /* push ebx */
            ii(0x1019_526d, 1); push(ecx);                              /* push ecx */
            ii(0x1019_526e, 2); push(fs);                               /* push fs */
            ii(0x1019_5270, 2); push(gs);                               /* push gs */
            ii(0x1019_5272, 1); push(es);                               /* push es */
            ii(0x1019_5273, 1); push(esi);                              /* push esi */
            ii(0x1019_5274, 1); push(es);                               /* push es */
            ii(0x1019_5275, 4); mov(ax, 0xb);                           /* mov ax, 0xb */
            ii(0x1019_5279, 4); lfs(edi, memd[ss, ebp + 0x20]);         /* lfs edi, [ebp+0x20] */
            ii(0x1019_527d, 3); call_far_ind(ss, ebp + 0x18);           /* call far dword [ebp+0x18] */
            ii(0x1019_5280, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1019_5282, 2); mov(es, edx);                           /* mov es, edx */
            ii(0x1019_5284, 4); mov(ax, 0xc);                           /* mov ax, 0xc */
            ii(0x1019_5288, 4); lfs(edi, memd[ss, ebp + 0x10]);         /* lfs edi, [ebp+0x10] */
            ii(0x1019_528c, 3); call_far_ind(ss, ebp + 0x8);            /* call far dword [ebp+0x8] */
            ii(0x1019_528f, 1); pop(es);                                /* pop es */
            ii(0x1019_5290, 1); pop(esi);                               /* pop esi */
            ii(0x1019_5291, 1); pop(es);                                /* pop es */
            ii(0x1019_5292, 2); pop(gs);                                /* pop gs */
            ii(0x1019_5294, 2); pop(fs);                                /* pop fs */
            ii(0x1019_5296, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_5297, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_5298, 1); pop(edi);                               /* pop edi */
            ii(0x1019_5299, 1); pop(esi);                               /* pop esi */
            ii(0x1019_529a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_529b, 1); ret();                                  /* ret */
        }
    }
}
