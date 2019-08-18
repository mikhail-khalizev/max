using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_588c-740366e5")]
        public void /* sys */ Method_1018_588c()
        {
            ii(0x1018_588c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_588d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_588e, 1); pushd(edx);                             /* push edx */
            ii(0x1018_588f, 1); pushd(esi);                             /* push esi */
            ii(0x1018_5890, 1); pushd(edi);                             /* push edi */
            ii(0x1018_5891, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1018_5896, 5); mov(ecx, 0xbb8);                        /* mov ecx, 0xbb8 */
            ii(0x1018_589b, 5); mov(eax, memd_a32[ds, 0x1020_88e8]);    /* mov eax, [0x102088e8] */
            ii(0x1018_58a0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_58a2, 6); mov(esi, memd_a32[ds, 0x1020_88ec]);    /* mov esi, [0x102088ec] */
            ii(0x1018_58a8, 6); mov(memd_a32[ds, 0x1020_a2ac], edx);    /* mov [0x1020a2ac], edx */
            ii(0x1018_58ae, 6); mov(memd_a32[ds, 0x1020_a2a4], ebx);    /* mov [0x1020a2a4], ebx */
            ii(0x1018_58b4, 6); mov(memd_a32[ds, 0x1020_a2a0], ecx);    /* mov [0x1020a2a0], ecx */
            ii(0x1018_58ba, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1018_58bc, 6); mov(ecx, memd_a32[ds, 0x1020_88ec]);    /* mov ecx, [0x102088ec] */
            ii(0x1018_58c2, 6); mov(edx, memd_a32[ds, 0x1020_88ec]);    /* mov edx, [0x102088ec] */
            ii(0x1018_58c8, 5); mov(memd_a32[ds, 0x1020_a2a8], eax);    /* mov [0x1020a2a8], eax */
            ii(0x1018_58cd, 3); sar(ecx, 0x2);                          /* sar ecx, 0x2 */
            ii(0x1018_58d0, 3); sar(edx, 0x3);                          /* sar edx, 0x3 */
            ii(0x1018_58d3, 6); cmp(esi, 0x1df);                        /* cmp esi, 0x1df */
            ii(0x1018_58d9, 2); if(jged(0x1018_58ec, 0x11)) goto l_0x1018_58ec; /* jge 0x101858ec */
            ii(0x1018_58db, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1018_58e0, 5); mov(memd_a32[ds, 0x1020_a25c], eax);    /* mov [0x1020a25c], eax */
            ii(0x1018_58e5, 5); mov(memd_a32[ds, 0x1020_a2b0], eax);    /* mov [0x1020a2b0], eax */
            ii(0x1018_58ea, 2); jmpd(0x1018_58fd, 0x11); goto l_0x1018_58fd; /* jmp 0x101858fd */
        l_0x1018_58ec:
            ii(0x1018_58ec, 5); mov(edi, 0x10);                         /* mov edi, 0x10 */
            ii(0x1018_58f1, 6); mov(memd_a32[ds, 0x1020_a25c], edi);    /* mov [0x1020a25c], edi */
            ii(0x1018_58f7, 6); mov(memd_a32[ds, 0x1020_a2b0], edi);    /* mov [0x1020a2b0], edi */
        l_0x1018_58fd:
            ii(0x1018_58fd, 6); calld_abs(memd_a32[ds, 0x101b_ddf0]);   /* call dword [0x101bddf0] */
            ii(0x1018_5903, 6); mov(ebx, memd_a32[ds, 0x1020_a2b0]);    /* mov ebx, [0x1020a2b0] */
            ii(0x1018_5909, 2); add(ebx, ebx);                          /* add ebx, ebx */
            ii(0x1018_590b, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1018_590d, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_590f, 3); imul(edx, edx, 0);                      /* imul edx, edx, 0x0 */
            ii(0x1018_5912, 5); mov(memd_a32[ds, 0x1020_a260], eax);    /* mov [0x1020a260], eax */
            ii(0x1018_5917, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_5919, 2); add(edx, ecx);                          /* add edx, ecx */
        l_0x1018_591b:
            ii(0x1018_591b, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1018_591e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_5920, 6); mov(memd_a32[ds, eax + 0x1020_a230], edx); /* mov [eax+0x1020a230], edx */
            ii(0x1018_5926, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1018_5928, 6); mov(memd_a32[ds, eax + 0x1020_a22c], ecx); /* mov [eax+0x1020a22c], ecx */
            ii(0x1018_592e, 3); cmp(eax, 0x28);                         /* cmp eax, 0x28 */
            ii(0x1018_5931, 2); if(jnzd(0x1018_591b, -0x18)) goto l_0x1018_591b; /* jnz 0x1018591b */
            ii(0x1018_5933, 1); popd(edi);                              /* pop edi */
            ii(0x1018_5934, 1); popd(esi);                              /* pop esi */
            ii(0x1018_5935, 1); popd(edx);                              /* pop edx */
            ii(0x1018_5936, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_5937, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_5938, 1); retd(); return;                         /* ret */
        }
    }
}
