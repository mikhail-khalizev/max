using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5069-373dadd1")]
        public void /* sys */ Method_1019_5069()
        {
            ii(0x1019_5069, 1); push(ebp);                              /* push ebp */
            ii(0x1019_506a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_506c, 1); push(esi);                              /* push esi */
            ii(0x1019_506d, 1); push(edi);                              /* push edi */
            ii(0x1019_506e, 1); push(ebx);                              /* push ebx */
            ii(0x1019_506f, 1); push(ecx);                              /* push ecx */
            ii(0x1019_5070, 2); push(fs);                               /* push fs */
            ii(0x1019_5072, 2); push(gs);                               /* push gs */
            ii(0x1019_5074, 1); push(es);                               /* push es */
            ii(0x1019_5075, 4); lfs(edi, memd[ss, ebp + 0x10]);         /* lfs edi, [ebp+0x10] */
            ii(0x1019_5079, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1019_507e, 4); mov(bx, memw[ss, ebp + 0x18]);          /* mov bx, [ebp+0x18] */
            ii(0x1019_5082, 4); mov(cx, memw[ss, ebp + 0x1c]);          /* mov cx, [ebp+0x1c] */
            ii(0x1019_5086, 4); mov(dx, memw[ss, ebp + 0x20]);          /* mov dx, [ebp+0x20] */
            ii(0x1019_508a, 2); mov(ch, dl);                            /* mov ch, dl */
            ii(0x1019_508c, 4); mov(si, memw[ss, ebp + 0x2c]);          /* mov si, [ebp+0x2c] */
            ii(0x1019_5090, 3); call_far_ind(memd[ss, ebp + 0x8]);      /* call far dword [ebp+0x8] */
            ii(0x1019_5093, 1); pop(es);                                /* pop es */
            ii(0x1019_5094, 2); pop(gs);                                /* pop gs */
            ii(0x1019_5096, 2); pop(fs);                                /* pop fs */
            ii(0x1019_5098, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_5099, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_509a, 1); pop(edi);                               /* pop edi */
            ii(0x1019_509b, 1); pop(esi);                               /* pop esi */
            ii(0x1019_509c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_509d, 1); ret();                                  /* ret */
        }
    }
}
