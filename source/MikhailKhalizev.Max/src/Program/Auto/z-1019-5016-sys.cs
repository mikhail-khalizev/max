using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5016-1cfc5bd9")]
        public void /* sys */ Method_1019_5016()
        {
            ii(0x1019_5016, 1); push(ebp);                              /* push ebp */
            ii(0x1019_5017, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_5019, 1); push(esi);                              /* push esi */
            ii(0x1019_501a, 1); push(edi);                              /* push edi */
            ii(0x1019_501b, 1); push(ebx);                              /* push ebx */
            ii(0x1019_501c, 1); push(ecx);                              /* push ecx */
            ii(0x1019_501d, 2); push(fs);                               /* push fs */
            ii(0x1019_501f, 2); push(gs);                               /* push gs */
            ii(0x1019_5021, 1); push(es);                               /* push es */
            ii(0x1019_5022, 4); lfs(edi, memd[ss, ebp + 0x10]);         /* lfs edi, [ebp+0x10] */
            ii(0x1019_5026, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1019_502b, 3); mov(ecx, memd[ss, ebp + 0x20]);         /* mov ecx, [ebp+0x20] */
            ii(0x1019_502e, 3); les(edi, memd[ss, ebp + 0x18]);         /* les edi, [ebp+0x18] */
            ii(0x1019_5031, 3); mov(edx, memd[ss, ebp + 0x24]);         /* mov edx, [ebp+0x24] */
            ii(0x1019_5034, 3); mov(ebx, memd[ss, ebp + 0x28]);         /* mov ebx, [ebp+0x28] */
            ii(0x1019_5037, 1); push(ds);                               /* push ds */
            ii(0x1019_5038, 2); pop(gs);                                /* pop gs */
            ii(0x1019_503a, 3); call_far_ind(memd[ss, ebp + 0x8]);      /* call far dword [ebp+0x8] */
            ii(0x1019_503d, 1); cli();                                  /* cli */
            ii(0x1019_503e, 3); mov(ebx, memd[ss, ebp + 0x2c]);         /* mov ebx, [ebp+0x2c] */
            ii(0x1019_5041, 2); mov(memd[ds, ebx], edi);                /* mov [ebx], edi */
            ii(0x1019_5043, 3); mov(memd[ds, ebx + 0x8], ecx);          /* mov [ebx+0x8], ecx */
            ii(0x1019_5046, 3); mov(memd[ds, ebx + 0x10], esi);         /* mov [ebx+0x10], esi */
            ii(0x1019_5049, 4); mov(ax, memw[ss, ebp + 0xc]);           /* mov ax, [ebp+0xc] */
            ii(0x1019_504d, 4); mov(memw[ds, ebx + 0x4], ax);           /* mov [ebx+0x4], ax */
            ii(0x1019_5051, 4); mov(ax, memw[ss, ebp + 0x14]);          /* mov ax, [ebp+0x14] */
            ii(0x1019_5055, 4); mov(memw[ds, ebx + 0xc], ax);           /* mov [ebx+0xc], ax */
            ii(0x1019_5059, 4); mov(memw[ds, ebx + 0x14], ax);          /* mov [ebx+0x14], ax */
            ii(0x1019_505d, 1); sti();                                  /* sti */
            ii(0x1019_505e, 1); pop(es);                                /* pop es */
            ii(0x1019_505f, 2); pop(gs);                                /* pop gs */
            ii(0x1019_5061, 2); pop(fs);                                /* pop fs */
            ii(0x1019_5063, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_5064, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_5065, 1); pop(edi);                               /* pop edi */
            ii(0x1019_5066, 1); pop(esi);                               /* pop esi */
            ii(0x1019_5067, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_5068, 1); ret();                                  /* ret */
        }
    }
}
