using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_6d9b-98926a73")]
        public void /* sys */ Method_1018_6d9b()
        {
            ii(0x1018_6d9b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_6d9c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_6d9d, 1); pushd(edx);                             /* push edx */
            ii(0x1018_6d9e, 1); pushd(esi);                             /* push esi */
            ii(0x1018_6d9f, 1); pushd(edi);                             /* push edi */
            ii(0x1018_6da0, 1); pushd(eax);                             /* push eax */
            ii(0x1018_6da1, 3); mov(ebx, memd_a32[ss, esp]);            /* mov ebx, [esp] */
            ii(0x1018_6da4, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1018_6da7, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_6daa, 5); calld(/* sys */ 0x1018_6b7c, -0x233);   /* call 0x10186b7c */
            ii(0x1018_6daf, 2); mov(ah, 0x5);                           /* mov ah, 0x5 */
            ii(0x1018_6db1, 2); mov(al, 0x1);                           /* mov al, 0x1 */
            ii(0x1018_6db3, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1018_6db5, 2); sbb(eax, eax);                          /* sbb eax, eax */
            ii(0x1018_6db7, 1); inc(eax);                               /* inc eax */
            ii(0x1018_6db8, 2); if(jzd(0x1018_6dca, 0x10)) goto l_0x1018_6dca; /* jz 0x10186dca */
            ii(0x1018_6dba, 3); mov(ax, bx);                            /* mov ax, bx */
            ii(0x1018_6dbd, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1018_6dc0, 3); mov(ax, cx);                            /* mov ax, cx */
            ii(0x1018_6dc3, 3); mov(memw_a32[ds, eax], di);             /* mov [eax], di */
            ii(0x1018_6dc6, 4); mov(memw_a32[ds, eax + 0x2], si);       /* mov [eax+0x2], si */
        l_0x1018_6dca:
            ii(0x1018_6dca, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_6dcc, 2); if(jzd(0x1018_6de7, 0x19)) goto l_0x1018_6de7; /* jz 0x10186de7 */
            ii(0x1018_6dce, 3); mov(ebx, memd_a32[ss, esp]);            /* mov ebx, [esp] */
            ii(0x1018_6dd1, 3); lea(edx, eax + 0x8);                    /* lea edx, [eax+0x8] */
            ii(0x1018_6dd4, 3); sub(ebx, 0x8);                          /* sub ebx, 0x8 */
            ii(0x1018_6dd7, 2); mov(memd_a32[ds, edx], ebx);            /* mov [edx], ebx */
            ii(0x1018_6dd9, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
            ii(0x1018_6de0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_6de2, 5); if(jmpd_func(0x1018_6e63, 0x7c)) return; /* jmp 0x10186e63 */
        l_0x1018_6de7:
            ii(0x1018_6de7, 9); test(memw_a32[ds, 0x1020_bd3e], 0xfff0); /* test word [0x1020bd3e], 0xfff0 */
            ii(0x1018_6df0, 2); if(jzd(0x1018_6dfc, 0xa)) goto l_0x1018_6dfc; /* jz 0x10186dfc */
            ii(0x1018_6df2, 10); mov(memd_a32[ds, 0x1020_bd3c], 0xf_ffff); /* mov dword [0x1020bd3c], 0xfffff */
        l_0x1018_6dfc:
            ii(0x1018_6dfc, 7); cmp(memd_a32[ss, esp], 0x1_0000);       /* cmp dword [esp], 0x10000 */
            ii(0x1018_6e03, 2); if(jad(0x1018_6e61, 0x5c)) goto l_0x1018_6e61; /* ja 0x10186e61 */
            ii(0x1018_6e05, 6); mov(ebx, memd_a32[ds, 0x1020_bd3c]);    /* mov ebx, [0x1020bd3c] */
            ii(0x1018_6e0b, 3); shr(ebx, 0x4);                          /* shr ebx, 0x4 */
            ii(0x1018_6e0e, 3); or(bl, 0x1);                            /* or bl, 0x1 */
            ii(0x1018_6e11, 2); mov(ah, 0x48);                          /* mov ah, 0x48 */
            ii(0x1018_6e13, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_6e15, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1018_6e17, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1018_6e19, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_6e1b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_6e1d, 2); if(jld(0x1018_6e61, 0x42)) goto l_0x1018_6e61; /* jl 0x10186e61 */
            ii(0x1018_6e1f, 3); mov(ebx, memd_a32[ss, esp]);            /* mov ebx, [esp] */
            ii(0x1018_6e22, 3); shr(ebx, 0x4);                          /* shr ebx, 0x4 */
            ii(0x1018_6e25, 2); mov(ah, 0x48);                          /* mov ah, 0x48 */
            ii(0x1018_6e27, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_6e29, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1018_6e2b, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1018_6e2d, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_6e2f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_6e31, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_6e33, 1); pushd(es);                              /* push es */
            ii(0x1018_6e34, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1018_6e36, 2); mov(ah, 0x49);                          /* mov ah, 0x49 */
            ii(0x1018_6e38, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_6e3a, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1018_6e3c, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1018_6e3e, 1); popd(es);                               /* pop es */
            ii(0x1018_6e3f, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_6e41, 2); if(jld(0x1018_6e61, 0x1e)) goto l_0x1018_6e61; /* jl 0x10186e61 */
            ii(0x1018_6e43, 2); mov(ah, 0);                             /* mov ah, 0x0 */
            ii(0x1018_6e45, 2); mov(al, 0x6);                           /* mov al, 0x6 */
            ii(0x1018_6e47, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1018_6e49, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_6e4b, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1018_6e4e, 3); mov(ax, dx);                            /* mov ax, dx */
            ii(0x1018_6e51, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1018_6e54, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1018_6e57, 3); mov(memd_a32[ds, eax - 0x4], esi);      /* mov [eax-0x4], esi */
            ii(0x1018_6e5a, 3); sub(edx, 0x8);                          /* sub edx, 0x8 */
            ii(0x1018_6e5d, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1018_6e5f, 2); if(jmpd_func(0x1018_6e63, 0x2)) return; /* jmp 0x10186e63 */
        l_0x1018_6e61:
            ii(0x1018_6e61, 2); xor(eax, eax);                          /* xor eax, eax */
        }
    }
}
