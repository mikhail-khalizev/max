using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_6e6c-d0b5f9bb")]
        public void /* sys */ Method_1018_6e6c()
        {
            ii(0x1018_6e6c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_6e6d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_6e6e, 1); pushd(edx);                             /* push edx */
            ii(0x1018_6e6f, 1); pushd(esi);                             /* push esi */
            ii(0x1018_6e70, 1); pushd(edi);                             /* push edi */
            ii(0x1018_6e71, 1); pushd(eax);                             /* push eax */
            ii(0x1018_6e72, 7); cmp(memd_a32[ds, 0x101c_1c50], 0);      /* cmp dword [0x101c1c50], 0x0 */
            ii(0x1018_6e79, 2); if(jnzd(0x1018_6e7f, 0x4)) goto l_0x1018_6e7f; /* jnz 0x10186e7f */
        l_0x1018_6e7b:
            ii(0x1018_6e7b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_6e7d, 2); if(jmpd_func(0x1018_6e63, -0x1c)) return; /* jmp 0x10186e63 */
        l_0x1018_6e7f:
            ii(0x1018_6e7f, 7); cmp(memd_a32[ds, 0x101b_e560], -0x2 /* 0xfe */); /* cmp dword [0x101be560], 0xfffffffe */
            ii(0x1018_6e86, 2); if(jzd(0x1018_6e7b, -0xd)) goto l_0x1018_6e7b; /* jz 0x10186e7b */
            ii(0x1018_6e88, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1018_6e8a, 5); calld(/* sys */ 0x1018_7068, 0x1d9);    /* call 0x10187068 */
            ii(0x1018_6e8f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_6e91, 2); if(jzd_func(0x1018_6e63, -0x30)) return; /* jz 0x10186e63 */
            ii(0x1018_6e93, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_6e95, 5); mov(al, memb_a32[ds, 0x101b_e58e]);     /* mov al, [0x101be58e] */
            ii(0x1018_6e9a, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1018_6e9d, 2); if(jnzd(0x1018_6eb4, 0x15)) goto l_0x1018_6eb4; /* jnz 0x10186eb4 */
            ii(0x1018_6e9f, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1018_6ea2, 5); calld(/* sys */ 0x1018_6d9b, -0x10c);   /* call 0x10186d9b */
            ii(0x1018_6ea7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_6ea9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_6eab, 2); if(jzd(0x1018_6ecf, 0x22)) goto l_0x1018_6ecf; /* jz 0x10186ecf */
            ii(0x1018_6ead, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1018_6eaf, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1018_6eb2, 2); jmpd(0x1018_6ecf, 0x1b); goto l_0x1018_6ecf; /* jmp 0x10186ecf */
        l_0x1018_6eb4:
            ii(0x1018_6eb4, 3); mov(ebx, memd_a32[ss, esp]);            /* mov ebx, [esp] */
            ii(0x1018_6eb7, 5); mov(eax, 0x8000_4800);                  /* mov eax, 0x80004800 */
            ii(0x1018_6ebc, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_6ebe, 2); sbb(ebx, ebx);                          /* sbb ebx, ebx */
            ii(0x1018_6ec0, 2); not(ebx);                               /* not ebx */
            ii(0x1018_6ec2, 2); and(eax, ebx);                          /* and eax, ebx */
            ii(0x1018_6ec4, 3); mov(ecx, memd_a32[ss, esp]);            /* mov ecx, [esp] */
            ii(0x1018_6ec7, 3); sub(ecx, 0x4);                          /* sub ecx, 0x4 */
            ii(0x1018_6eca, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_6ecc, 3); mov(memd_a32[ss, esp], ecx);            /* mov [esp], ecx */
        l_0x1018_6ecf:
            ii(0x1018_6ecf, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_6ed1, 2); if(jzd(0x1018_6e7b, -0x58)) goto l_0x1018_6e7b; /* jz 0x10186e7b */
            ii(0x1018_6ed3, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1018_6ed6, 3); mov(esi, memd_a32[ss, esp]);            /* mov esi, [esp] */
            ii(0x1018_6ed9, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1018_6edc, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x1018_6ede, 2); if(jad(0x1018_6e7b, -0x65)) goto l_0x1018_6e7b; /* ja 0x10186e7b */
            ii(0x1018_6ee0, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1018_6ee3, 3); cmp(eax, 0x38);                         /* cmp eax, 0x38 */
            ii(0x1018_6ee6, 2); if(jbd(0x1018_6e7b, -0x6d)) goto l_0x1018_6e7b; /* jb 0x10186e7b */
            ii(0x1018_6ee8, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1018_6eea, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_6eec, 5); calld(/* sys */ 0x1018_6cd7, -0x21a);   /* call 0x10186cd7 */
            ii(0x1018_6ef1, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_6ef3, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1018_6ef5, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1018_6ef8, 2); or(al, 0x1);                            /* or al, 0x1 */
            ii(0x1018_6efa, 2); mov(memd_a32[ds, ebx], eax);            /* mov [ebx], eax */
            ii(0x1018_6efc, 3); mov(edi, memd_a32[ds, edx + 0x18]);     /* mov edi, [edx+0x18] */
            ii(0x1018_6eff, 7); mov(memd_a32[ds, edx + 0x14], 0xffff_ffff); /* mov dword [edx+0x14], 0xffffffff */
            ii(0x1018_6f06, 1); inc(edi);                               /* inc edi */
            ii(0x1018_6f07, 3); lea(eax, ebx + 0x4);                    /* lea eax, [ebx+0x4] */
            ii(0x1018_6f0a, 3); mov(memd_a32[ds, edx + 0x18], edi);     /* mov [edx+0x18], edi */
            ii(0x1018_6f0d, 5); calld(Definitions.sys_free, -0x1_be51); /* call 0x1016b0c1 */
            ii(0x1018_6f12, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1018_6f17, 5); if(jmpd_func(0x1018_6e63, -0xb9)) return; /* jmp 0x10186e63 */
        }
    }
}
