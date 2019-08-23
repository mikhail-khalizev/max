using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_aa08-67f60df2")]
        public void /* sys */ Method_1019_aa08()
        {
            ii(0x1019_aa08, 1); push(ebx);                              /* push ebx */
            ii(0x1019_aa09, 1); push(ecx);                              /* push ecx */
            ii(0x1019_aa0a, 1); push(edx);                              /* push edx */
            ii(0x1019_aa0b, 1); push(esi);                              /* push esi */
            ii(0x1019_aa0c, 1); push(edi);                              /* push edi */
            ii(0x1019_aa0d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_aa0f, 5); mov(edx, 0x8000);                       /* mov edx, 0x8000 */
            ii(0x1019_aa14, 5); mov(al, memb[ds, 0x101b_e58e]);         /* mov al, [0x101be58e] */
            ii(0x1019_aa19, 6); mov(memd[ds, 0x101c_1c54], edx);        /* mov [0x101c1c54], edx */
            ii(0x1019_aa1f, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1019_aa22, 2); if(jl(0x1019_aa29, 0x5)) goto l_0x1019_aa29; /* jl 0x1019aa29 */
            ii(0x1019_aa24, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1019_aa27, 2); if(jle(0x1019_aa30, 0x7)) goto l_0x1019_aa30; /* jle 0x1019aa30 */
        l_0x1019_aa29:
            ii(0x1019_aa29, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1019_aa2e, 2); jmp(0x1019_aa32, 0x2); goto l_0x1019_aa32; /* jmp 0x1019aa32 */
        l_0x1019_aa30:
            ii(0x1019_aa30, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1019_aa32:
            ii(0x1019_aa32, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_aa34, 2); if(jz(0x1019_aa6b, 0x35)) goto l_0x1019_aa6b; /* jz 0x1019aa6b */
            ii(0x1019_aa36, 5); call(/* sys */ 0x1019_bf15, 0x14da);    /* call 0x1019bf15 */
            ii(0x1019_aa3b, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1019_aa3e, 2); if(jnz(0x1019_aa6b, 0x2b)) goto l_0x1019_aa6b; /* jnz 0x1019aa6b */
            ii(0x1019_aa40, 5); mov(edx, /* sys */ 0x1016_c9db);        /* mov edx, 0x1016c9db */
            ii(0x1019_aa45, 5); mov(eax, /* sys */ 0x1016_c9d0);        /* mov eax, 0x1016c9d0 */
            ii(0x1019_aa4a, 6); sub(edx, /* sys */ 0x1016_c9d0);        /* sub edx, 0x1016c9d0 */
            ii(0x1019_aa50, 3); mov(di, dx);                            /* mov di, dx */
            ii(0x1019_aa53, 3); shr(edx, 0x10);                         /* shr edx, 0x10 */
            ii(0x1019_aa56, 3); mov(si, dx);                            /* mov si, dx */
            ii(0x1019_aa59, 3); mov(bx, ax);                            /* mov bx, ax */
            ii(0x1019_aa5c, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1019_aa5f, 3); mov(cx, ax);                            /* mov cx, ax */
            ii(0x1019_aa62, 4); mov(ax, 0x600);                         /* mov ax, 0x600 */
            ii(0x1019_aa66, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_aa68, 3); sbb(ax, ax);                            /* sbb ax, ax */
        l_0x1019_aa6b:
            ii(0x1019_aa6b, 1); pop(edi);                               /* pop edi */
            ii(0x1019_aa6c, 1); pop(esi);                               /* pop esi */
            ii(0x1019_aa6d, 1); pop(edx);                               /* pop edx */
            ii(0x1019_aa6e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_aa6f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_aa70, 1); ret();                                  /* ret */
        }
    }
}
