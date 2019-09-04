using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_5f8c-40ad3fd")]
        public void /* sys */ Method_1018_5f8c()
        {
            ii(0x1018_5f8c, 1); push(ecx);                              /* push ecx */
            ii(0x1018_5f8d, 1); push(esi);                              /* push esi */
            ii(0x1018_5f8e, 1); push(edi);                              /* push edi */
            ii(0x1018_5f8f, 1); push(ebp);                              /* push ebp */
            ii(0x1018_5f90, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1018_5f92, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_5f94, 1); movsd();                                /* movsd */
            ii(0x1018_5f95, 1); movsd();                                /* movsd */
            ii(0x1018_5f96, 1); movsd();                                /* movsd */
            ii(0x1018_5f97, 1); movsd();                                /* movsd */
            ii(0x1018_5f98, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x1018_5f9a, 3); cmp(ecx, memd[ds, edx + 8]);            /* cmp ecx, [edx+0x8] */
            ii(0x1018_5f9d, 2); if(jg(0x1018_5fb8, 0x19)) goto l_0x1018_5fb8; /* jg 0x10185fb8 */
            ii(0x1018_5f9f, 3); mov(ecx, memd[ds, eax + 8]);            /* mov ecx, [eax+0x8] */
            ii(0x1018_5fa2, 2); mov(edi, memd[ds, edx]);                /* mov edi, [edx] */
            ii(0x1018_5fa4, 2); cmp(ecx, edi);                          /* cmp ecx, edi */
            ii(0x1018_5fa6, 2); if(jl(0x1018_5fb8, 0x10)) goto l_0x1018_5fb8; /* jl 0x10185fb8 */
            ii(0x1018_5fa8, 3); mov(ecx, memd[ds, eax + 4]);            /* mov ecx, [eax+0x4] */
            ii(0x1018_5fab, 3); cmp(ecx, memd[ds, edx + 12]);           /* cmp ecx, [edx+0xc] */
            ii(0x1018_5fae, 2); if(jg(0x1018_5fb8, 8)) goto l_0x1018_5fb8; /* jg 0x10185fb8 */
            ii(0x1018_5fb0, 3); mov(ecx, memd[ds, eax + 12]);           /* mov ecx, [eax+0xc] */
            ii(0x1018_5fb3, 3); cmp(ecx, memd[ds, edx + 4]);            /* cmp ecx, [edx+0x4] */
            ii(0x1018_5fb6, 2); if(jge(0x1018_5fc2, 0xa)) goto l_0x1018_5fc2; /* jge 0x10185fc2 */
        l_0x1018_5fb8:
            ii(0x1018_5fb8, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1018_5fbd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_5fbe, 1); pop(edi);                               /* pop edi */
            ii(0x1018_5fbf, 1); pop(esi);                               /* pop esi */
            ii(0x1018_5fc0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_5fc1, 1); ret(); return;                          /* ret */
        l_0x1018_5fc2:
            ii(0x1018_5fc2, 2); cmp(edi, memd[ds, eax]);                /* cmp edi, [eax] */
            ii(0x1018_5fc4, 2); if(jle(0x1018_5fc8, 2)) goto l_0x1018_5fc8; /* jle 0x10185fc8 */
            ii(0x1018_5fc6, 2); mov(memd[ds, ebx], edi);                /* mov [ebx], edi */
        l_0x1018_5fc8:
            ii(0x1018_5fc8, 3); mov(ecx, memd[ds, eax + 8]);            /* mov ecx, [eax+0x8] */
            ii(0x1018_5fcb, 3); mov(ebp, memd[ds, edx + 8]);            /* mov ebp, [edx+0x8] */
            ii(0x1018_5fce, 2); cmp(ecx, ebp);                          /* cmp ecx, ebp */
            ii(0x1018_5fd0, 2); if(jle(0x1018_5fd5, 3)) goto l_0x1018_5fd5; /* jle 0x10185fd5 */
            ii(0x1018_5fd2, 3); mov(memd[ds, ebx + 8], ebp);            /* mov [ebx+0x8], ebp */
        l_0x1018_5fd5:
            ii(0x1018_5fd5, 3); mov(ecx, memd[ds, eax + 4]);            /* mov ecx, [eax+0x4] */
            ii(0x1018_5fd8, 3); mov(esi, memd[ds, edx + 4]);            /* mov esi, [edx+0x4] */
            ii(0x1018_5fdb, 2); cmp(ecx, esi);                          /* cmp ecx, esi */
            ii(0x1018_5fdd, 2); if(jge(0x1018_5fe2, 3)) goto l_0x1018_5fe2; /* jge 0x10185fe2 */
            ii(0x1018_5fdf, 3); mov(memd[ds, ebx + 4], esi);            /* mov [ebx+0x4], esi */
        l_0x1018_5fe2:
            ii(0x1018_5fe2, 3); mov(eax, memd[ds, eax + 12]);           /* mov eax, [eax+0xc] */
            ii(0x1018_5fe5, 3); mov(edi, memd[ds, edx + 12]);           /* mov edi, [edx+0xc] */
            ii(0x1018_5fe8, 2); cmp(eax, edi);                          /* cmp eax, edi */
            ii(0x1018_5fea, 2); if(jle(0x1018_5fef, 3)) goto l_0x1018_5fef; /* jle 0x10185fef */
            ii(0x1018_5fec, 3); mov(memd[ds, ebx + 12], edi);           /* mov [ebx+0xc], edi */
        l_0x1018_5fef:
            ii(0x1018_5fef, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_5ff1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_5ff2, 1); pop(edi);                               /* pop edi */
            ii(0x1018_5ff3, 1); pop(esi);                               /* pop esi */
            ii(0x1018_5ff4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_5ff5, 1); ret();                                  /* ret */
        }
    }
}
