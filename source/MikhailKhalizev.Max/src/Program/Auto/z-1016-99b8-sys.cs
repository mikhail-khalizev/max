using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_99b8-b2b0e91b")]
        public void /* sys */ Method_1016_99b8()
        {
            ii(0x1016_99b8, 1); push(esi);                              /* push esi */
            ii(0x1016_99b9, 1); push(edi);                              /* push edi */
            ii(0x1016_99ba, 1); push(ebp);                              /* push ebp */
            ii(0x1016_99bb, 3); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1016_99be, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1016_99c0, 3); mov(memd[ss, esp], ebx);                /* mov [esp], ebx */
            ii(0x1016_99c3, 4); mov(memd[ss, esp + 4], ecx);            /* mov [esp+0x4], ecx */
            ii(0x1016_99c7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_99c9, 7); cmp(memd[ds, 0x101b_ddbc], 0);          /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_99d0, 6); if(jz(0x1016_9a6c, 0x96)) goto l_0x1016_9a6c; /* jz 0x10169a6c */
            ii(0x1016_99d6, 3); cmp(ebp, 0x40);                         /* cmp ebp, 0x40 */
            ii(0x1016_99d9, 6); if(jg(0x1016_9a6c, 0x8d)) goto l_0x1016_9a6c; /* jg 0x10169a6c */
            ii(0x1016_99df, 6); mov(ecx, memd[ds, 0x101c_b2f0]);        /* mov ecx, [0x101cb2f0] */
            ii(0x1016_99e5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_99e7, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_99e9, 2); if(jnz(0x1016_9a53, 0x68)) goto l_0x1016_9a53; /* jnz 0x10169a53 */
        l_0x1016_99eb:
            ii(0x1016_99eb, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1016_99ed, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_99ef, 6); mov(memd[ds, ebx + 0x101c_b2e8], edi);  /* mov [ebx+0x101cb2e8], edi */
            ii(0x1016_99f5, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_99f7, 2); if(jle(0x1016_9a36, 0x3d)) goto l_0x1016_9a36; /* jle 0x10169a36 */
            ii(0x1016_99f9, 7); lea(edi, memd[ds, ebp * 4]);            /* lea edi, [ebp*4] */
            ii(0x1016_9a00, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
        l_0x1016_9a02:
            ii(0x1016_9a02, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
            ii(0x1016_9a04, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_9a06, 5); call(/* sys */ 0x1016_7f00, -0x1b0b);   /* call 0x10167f00 */
            ii(0x1016_9a0b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_9a0d, 2); if(jz(0x1016_9a6c, 0x5d)) goto l_0x1016_9a6c; /* jz 0x10169a6c */
            ii(0x1016_9a0f, 5); mov(edx, 0x101c_b2e4);                  /* mov edx, 0x101cb2e4 */
            ii(0x1016_9a14, 7); mov(memd[ds, ecx + ebx + 0x101c_b2f4], eax); /* mov [ecx+ebx+0x101cb2f4], eax */
            ii(0x1016_9a1b, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1016_9a1d, 3); mov(memd[ds, eax + 104], edx);          /* mov [eax+0x68], edx */
            ii(0x1016_9a20, 4); test(memb[ds, eax + 6], 2);             /* test byte [eax+0x6], 0x2 */
            ii(0x1016_9a24, 2); if(jz(0x1016_9a2c, 6)) goto l_0x1016_9a2c; /* jz 0x10169a2c */
            ii(0x1016_9a26, 6); inc(memd[ds, ebx + 0x101c_b2e8]);       /* inc dword [ebx+0x101cb2e8] */
        l_0x1016_9a2c:
            ii(0x1016_9a2c, 3); add(ecx, 4);                            /* add ecx, 0x4 */
            ii(0x1016_9a2f, 3); add(esi, 4);                            /* add esi, 0x4 */
            ii(0x1016_9a32, 2); cmp(ecx, edi);                          /* cmp ecx, edi */
            ii(0x1016_9a34, 2); if(jl(0x1016_9a02, -0x34)) goto l_0x1016_9a02; /* jl 0x10169a02 */
        l_0x1016_9a36:
            ii(0x1016_9a36, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_9a39, 6); mov(memd[ds, ebx + 0x101c_b2f0], ebp);  /* mov [ebx+0x101cb2f0], ebp */
            ii(0x1016_9a3f, 6); mov(memd[ds, ebx + 0x101c_b2e4], eax);  /* mov [ebx+0x101cb2e4], eax */
            ii(0x1016_9a45, 4); mov(eax, memd[ss, esp + 4]);            /* mov eax, [esp+0x4] */
            ii(0x1016_9a49, 6); mov(memd[ds, ebx + 0x101c_b2ec], eax);  /* mov [ebx+0x101cb2ec], eax */
            ii(0x1016_9a4f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_9a51, 2); jmp(0x1016_9a71, 0x1e); goto l_0x1016_9a71; /* jmp 0x10169a71 */
        l_0x1016_9a53:
            ii(0x1016_9a53, 6); add(ebx, 0x110);                        /* add ebx, 0x110 */
            ii(0x1016_9a59, 6); cmp(ebx, 0x4400);                       /* cmp ebx, 0x4400 */
            ii(0x1016_9a5f, 2); if(jge(0x1016_9a6c, 0xb)) goto l_0x1016_9a6c; /* jge 0x10169a6c */
            ii(0x1016_9a61, 7); cmp(memd[ds, ebx + 0x101c_b2f0], 0);    /* cmp dword [ebx+0x101cb2f0], 0x0 */
            ii(0x1016_9a68, 2); if(jz(0x1016_99eb, -0x7f)) goto l_0x1016_99eb; /* jz 0x101699eb */
            ii(0x1016_9a6a, 2); jmp(0x1016_9a53, -0x19); goto l_0x1016_9a53; /* jmp 0x10169a53 */
        l_0x1016_9a6c:
            ii(0x1016_9a6c, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
        l_0x1016_9a71:
            ii(0x1016_9a71, 3); add(esp, 8);                            /* add esp, 0x8 */
            ii(0x1016_9a74, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_9a75, 1); pop(edi);                               /* pop edi */
            ii(0x1016_9a76, 1); pop(esi);                               /* pop esi */
            ii(0x1016_9a77, 1); ret();                                  /* ret */
        }
    }
}
