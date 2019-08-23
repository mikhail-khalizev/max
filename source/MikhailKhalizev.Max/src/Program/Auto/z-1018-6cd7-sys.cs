using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_6cd7-3b76d1c0")]
        public void /* sys */ Method_1018_6cd7()
        {
            ii(0x1018_6cd7, 1); push(ebx);                              /* push ebx */
            ii(0x1018_6cd8, 1); push(edx);                              /* push edx */
            ii(0x1018_6cd9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_6cdb, 5); mov(eax, memd[ds, 0x101b_de0c]);        /* mov eax, [0x101bde0c] */
            ii(0x1018_6ce0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_6ce2, 2); jmp(0x1018_6ced, 0x9); goto l_0x1018_6ced; /* jmp 0x10186ced */
        l_0x1018_6ce4:
            ii(0x1018_6ce4, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1018_6ce6, 2); if(jb(0x1018_6cf1, 0x9)) goto l_0x1018_6cf1; /* jb 0x10186cf1 */
            ii(0x1018_6ce8, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_6cea, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
        l_0x1018_6ced:
            ii(0x1018_6ced, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_6cef, 2); if(jnz(0x1018_6ce4, -0xd)) goto l_0x1018_6ce4; /* jnz 0x10186ce4 */
        l_0x1018_6cf1:
            ii(0x1018_6cf1, 3); mov(memd[ds, edx + 0x4], ebx);          /* mov [edx+0x4], ebx */
            ii(0x1018_6cf4, 3); mov(memd[ds, edx + 0x8], eax);          /* mov [edx+0x8], eax */
            ii(0x1018_6cf7, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1018_6cf9, 2); if(jz(0x1018_6d00, 0x5)) goto l_0x1018_6d00; /* jz 0x10186d00 */
            ii(0x1018_6cfb, 3); mov(memd[ds, ebx + 0x8], edx);          /* mov [ebx+0x8], edx */
            ii(0x1018_6cfe, 2); jmp(0x1018_6d06, 0x6); goto l_0x1018_6d06; /* jmp 0x10186d06 */
        l_0x1018_6d00:
            ii(0x1018_6d00, 6); mov(memd[ds, 0x101b_de0c], edx);        /* mov [0x101bde0c], edx */
        l_0x1018_6d06:
            ii(0x1018_6d06, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_6d08, 2); if(jz(0x1018_6d0d, 0x3)) goto l_0x1018_6d0d; /* jz 0x10186d0d */
            ii(0x1018_6d0a, 3); mov(memd[ds, eax + 0x4], edx);          /* mov [eax+0x4], edx */
        l_0x1018_6d0d:
            ii(0x1018_6d0d, 3); lea(ebx, memd[ds, edx + 0x20]);         /* lea ebx, [edx+0x20] */
            ii(0x1018_6d10, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x1018_6d12, 3); add(edx, 0x2c);                         /* add edx, 0x2c */
            ii(0x1018_6d15, 7); mov(memd[ds, edx - 0xc], 0);            /* mov dword [edx-0xc], 0x0 */
            ii(0x1018_6d1c, 7); mov(memd[ds, edx - 0x1c], 0);           /* mov dword [edx-0x1c], 0x0 */
            ii(0x1018_6d23, 7); mov(memd[ds, edx - 0x14], 0);           /* mov dword [edx-0x14], 0x0 */
            ii(0x1018_6d2a, 7); mov(memd[ds, edx - 0x10], 0);           /* mov dword [edx-0x10], 0x0 */
            ii(0x1018_6d31, 3); mov(memd[ds, edx - 0x8], ebx);          /* mov [edx-0x8], ebx */
            ii(0x1018_6d34, 3); mov(memd[ds, edx - 0x4], ebx);          /* mov [edx-0x4], ebx */
            ii(0x1018_6d37, 3); sub(eax, 0x2c);                         /* sub eax, 0x2c */
            ii(0x1018_6d3a, 3); mov(memd[ds, edx - 0x20], ebx);         /* mov [edx-0x20], ebx */
            ii(0x1018_6d3d, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x1018_6d3f, 7); mov(memd[ds, edx + eax], 0xffff_ffff);  /* mov dword [edx+eax], 0xffffffff */
            ii(0x1018_6d46, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_6d48, 1); pop(edx);                               /* pop edx */
            ii(0x1018_6d49, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_6d4a, 1); ret();                                  /* ret */
        }
    }
}
