using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_9ecc-292a2a7c")]
        public void /* sys */ Method_1016_9ecc()
        {
            ii(0x1016_9ecc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_9ecd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_9ece, 1); pushd(edx);                             /* push edx */
            ii(0x1016_9ecf, 1); pushd(esi);                             /* push esi */
            ii(0x1016_9ed0, 1); pushd(edi);                             /* push edi */
            ii(0x1016_9ed1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_9ed2, 3); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1016_9ed5, 5); mov(ebp, 0xffff_ffff);                  /* mov ebp, 0xffffffff */
            ii(0x1016_9eda, 5); mov(ecx, 0xb);                          /* mov ecx, 0xb */
            ii(0x1016_9edf, 2); mov(edi, esp);                          /* mov edi, esp */
            ii(0x1016_9ee1, 5); mov(esi, /* sys */ 0x1016_9ea0);        /* mov esi, 0x10169ea0 */
            ii(0x1016_9ee6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_9ee8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_9eea, 2); rep_a32(() => movsd_a32());             /* rep movsd */
        l_0x1016_9eec:
            ii(0x1016_9eec, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_9eee, 5); calld(/* sys */ 0x1016_9f6c, 0x79);     /* call 0x10169f6c */
            ii(0x1016_9ef3, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_9ef6, 2); if(jnzd(0x1016_9f02, 0xa)) goto l_0x1016_9f02; /* jnz 0x10169f02 */
            ii(0x1016_9ef8, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_9efa, 6); mov(memd_a32[ds, ebx + 0x101c_f6e4], ecx); /* mov [ebx+0x101cf6e4], ecx */
            ii(0x1016_9f00, 2); jmpd(0x1016_9f09, 0x7); goto l_0x1016_9f09; /* jmp 0x10169f09 */
        l_0x1016_9f02:
            ii(0x1016_9f02, 3); cmp(ebp, -0x1 /* 0xff */);              /* cmp ebp, 0xffffffff */
            ii(0x1016_9f05, 2); if(jnzd(0x1016_9f09, 0x2)) goto l_0x1016_9f09; /* jnz 0x10169f09 */
            ii(0x1016_9f07, 2); mov(ebp, edx);                          /* mov ebp, edx */
        l_0x1016_9f09:
            ii(0x1016_9f09, 1); inc(edx);                               /* inc edx */
            ii(0x1016_9f0a, 3); add(ebx, 0x14);                         /* add ebx, 0x14 */
            ii(0x1016_9f0d, 3); cmp(edx, 0xa);                          /* cmp edx, 0xa */
            ii(0x1016_9f10, 2); if(jld(0x1016_9eec, -0x26)) goto l_0x1016_9eec; /* jl 0x10169eec */
            ii(0x1016_9f12, 3); cmp(ebp, -0x1 /* 0xff */);              /* cmp ebp, 0xffffffff */
            ii(0x1016_9f15, 2); if(jnzd(0x1016_9f1b, 0x4)) goto l_0x1016_9f1b; /* jnz 0x10169f1b */
            ii(0x1016_9f17, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_9f19, 2); jmpd(0x1016_9f30, 0x15); goto l_0x1016_9f30; /* jmp 0x10169f30 */
        l_0x1016_9f1b:
            ii(0x1016_9f1b, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_9f1d, 5); calld(/* sys */ 0x1016_a0f0, 0x1ce);    /* call 0x1016a0f0 */
            ii(0x1016_9f22, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_9f25, 2); if(jzd(0x1016_9f30, 0x9)) goto l_0x1016_9f30; /* jz 0x10169f30 */
            ii(0x1016_9f27, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_9f29, 5); calld(/* sys */ 0x1016_a24c, 0x31e);    /* call 0x1016a24c */
            ii(0x1016_9f2e, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_9f30:
            ii(0x1016_9f30, 3); add(esp, 0x2c);                         /* add esp, 0x2c */
            ii(0x1016_9f33, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_9f34, 1); popd(edi);                              /* pop edi */
            ii(0x1016_9f35, 1); popd(esi);                              /* pop esi */
            ii(0x1016_9f36, 1); popd(edx);                              /* pop edx */
            ii(0x1016_9f37, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_9f38, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_9f39, 1); retd();                                 /* ret */
        }
    }
}
