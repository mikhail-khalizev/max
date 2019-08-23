using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9193-8e86d305")]
        public void /* sys */ Method_1017_9193()
        {
            ii(0x1017_9193, 1); push(ebx);                              /* push ebx */
            ii(0x1017_9194, 1); push(ecx);                              /* push ecx */
            ii(0x1017_9195, 1); push(ebp);                              /* push ebp */
            ii(0x1017_9196, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_9198, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_919a, 2); if(jnz(0x1017_91a5, 0x9)) goto l_0x1017_91a5; /* jnz 0x101791a5 */
            ii(0x1017_919c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1017_91a1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_91a2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_91a3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_91a4, 1); ret(); return;                          /* ret */
        l_0x1017_91a5:
            ii(0x1017_91a5, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1017_91a7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_91a9, 2); if(jnz(0x1017_91b0, 0x5)) goto l_0x1017_91b0; /* jnz 0x101791b0 */
            ii(0x1017_91ab, 3); lea(eax, memd[ds, edx + 0x2c]);         /* lea eax, [edx+0x2c] */
            ii(0x1017_91ae, 2); jmp(0x1017_91e0, 0x30); goto l_0x1017_91e0; /* jmp 0x101791e0 */
        l_0x1017_91b0:
            ii(0x1017_91b0, 6); mov(edx, memd[ds, 0x101b_de0c]);        /* mov edx, [0x101bde0c] */
        l_0x1017_91b6:
            ii(0x1017_91b6, 3); mov(ecx, memd[ds, edx + 0x8]);          /* mov ecx, [edx+0x8] */
            ii(0x1017_91b9, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_91bb, 2); if(jz(0x1017_91ca, 0xd)) goto l_0x1017_91ca; /* jz 0x101791ca */
            ii(0x1017_91bd, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1017_91bf, 2); if(ja(0x1017_91c5, 0x4)) goto l_0x1017_91c5; /* ja 0x101791c5 */
            ii(0x1017_91c1, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1017_91c3, 2); if(jb(0x1017_91ca, 0x5)) goto l_0x1017_91ca; /* jb 0x101791ca */
        l_0x1017_91c5:
            ii(0x1017_91c5, 3); mov(edx, memd[ds, edx + 0x8]);          /* mov edx, [edx+0x8] */
            ii(0x1017_91c8, 2); jmp(0x1017_91b6, -0x14); goto l_0x1017_91b6; /* jmp 0x101791b6 */
        l_0x1017_91ca:
            ii(0x1017_91ca, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x1017_91cc, 3); and(cl, 0xfe);                          /* and cl, 0xfe */
            ii(0x1017_91cf, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1017_91d1, 2); cmp(ecx, eax);                          /* cmp ecx, eax */
            ii(0x1017_91d3, 2); if(ja(0x1017_91de, 0x9)) goto l_0x1017_91de; /* ja 0x101791de */
            ii(0x1017_91d5, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1017_91da, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_91db, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_91dc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_91dd, 1); ret(); return;                          /* ret */
        l_0x1017_91de:
            ii(0x1017_91de, 2); mov(eax, ecx);                          /* mov eax, ecx */
        l_0x1017_91e0:
            ii(0x1017_91e0, 3); cmp(memd[ds, eax], -0x1 /* 0xff */);    /* cmp dword [eax], 0xffffffff */
            ii(0x1017_91e3, 2); if(jnz(0x1017_920a, 0x25)) goto l_0x1017_920a; /* jnz 0x1017920a */
            ii(0x1017_91e5, 3); mov(ebp, memd[ds, edx + 0x8]);          /* mov ebp, [edx+0x8] */
            ii(0x1017_91e8, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1017_91ea, 2); if(jnz(0x1017_9203, 0x17)) goto l_0x1017_9203; /* jnz 0x10179203 */
            ii(0x1017_91ec, 6); mov(memw[ds, ebx + 0x4], 0);            /* mov word [ebx+0x4], 0x0 */
            ii(0x1017_91f2, 3); mov(memd[ds, ebx + 0xa], ebp);          /* mov [ebx+0xa], ebp */
            ii(0x1017_91f5, 3); mov(memd[ds, ebx + 0x6], ebp);          /* mov [ebx+0x6], ebp */
            ii(0x1017_91f8, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1017_91fd, 2); mov(memd[ds, ebx], ebp);                /* mov [ebx], ebp */
            ii(0x1017_91ff, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_9200, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_9201, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_9202, 1); ret(); return;                          /* ret */
        l_0x1017_9203:
            ii(0x1017_9203, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1017_9205, 3); lea(eax, memd[ss, ebp + 0x2c]);         /* lea eax, [ebp+0x2c] */
            ii(0x1017_9208, 2); jmp(0x1017_91e0, -0x2a); goto l_0x1017_91e0; /* jmp 0x101791e0 */
        l_0x1017_920a:
            ii(0x1017_920a, 7); mov(memd[ds, ebx + 0xa], 0x1);          /* mov dword [ebx+0xa], 0x1 */
            ii(0x1017_9211, 3); mov(memw[ds, ebx + 0x4], ds);           /* mov [ebx+0x4], ds */
            ii(0x1017_9214, 2); mov(memd[ds, ebx], eax);                /* mov [ebx], eax */
            ii(0x1017_9216, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1017_9218, 3); and(dl, 0xfe);                          /* and dl, 0xfe */
            ii(0x1017_921b, 3); mov(memd[ds, ebx + 0x6], edx);          /* mov [ebx+0x6], edx */
            ii(0x1017_921e, 3); test(memb[ds, eax], 0x1);               /* test byte [eax], 0x1 */
            ii(0x1017_9221, 2); if(jz(0x1017_922a, 0x7)) goto l_0x1017_922a; /* jz 0x1017922a */
            ii(0x1017_9223, 7); mov(memd[ds, ebx + 0xa], 0);            /* mov dword [ebx+0xa], 0x0 */
        l_0x1017_922a:
            ii(0x1017_922a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_922c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_922d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_922e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_922f, 1); ret();                                  /* ret */
        }
    }
}
