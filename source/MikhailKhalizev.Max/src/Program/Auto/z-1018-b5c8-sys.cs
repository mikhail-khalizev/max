using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("45a47d52-d849-4998-926f-f1b587e1e269")]
        public void /* sys */ Method_1018_b5c8()
        {
            ii(0x1018_b5c8, 1); pushd(esi);                             /* push esi */
            ii(0x1018_b5c9, 1); pushd(edi);                             /* push edi */
            ii(0x1018_b5ca, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_b5cb, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1018_b5cd, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_b5cf, 3); mov(memd_a32[ss, ebp + 0x8], eax);      /* mov [ebp+0x8], eax */
            ii(0x1018_b5d2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_b5d4, 3); mov(memd_a32[ss, ebp + 0xc], ebx);      /* mov [ebp+0xc], ebx */
            ii(0x1018_b5d7, 3); mov(memd_a32[ss, ebp + 0x4], edx);      /* mov [ebp+0x4], edx */
            ii(0x1018_b5da, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1018_b5dc, 2); if(jzd(0x1018_b5e9, 0xb)) goto l_0x1018_b5e9; /* jz 0x1018b5e9 */
            ii(0x1018_b5de, 2); mov(esi, ecx);                          /* mov esi, ecx */
            ii(0x1018_b5e0, 3); lea(edi, ebp + 0x10);                   /* lea edi, [ebp+0x10] */
            ii(0x1018_b5e3, 1); movsd_a32();                            /* movsd */
            ii(0x1018_b5e4, 1); movsd_a32();                            /* movsd */
            ii(0x1018_b5e5, 1); movsd_a32();                            /* movsd */
            ii(0x1018_b5e6, 1); movsd_a32();                            /* movsd */
            ii(0x1018_b5e7, 2); jmpd(0x1018_b5f5, 0xc); goto l_0x1018_b5f5; /* jmp 0x1018b5f5 */
        l_0x1018_b5e9:
            ii(0x1018_b5e9, 3); mov(memd_a32[ss, ebp + 0x10], edx);     /* mov [ebp+0x10], edx */
            ii(0x1018_b5ec, 3); mov(memd_a32[ss, ebp + 0x14], edx);     /* mov [ebp+0x14], edx */
            ii(0x1018_b5ef, 3); mov(memd_a32[ss, ebp + 0x18], edx);     /* mov [ebp+0x18], edx */
            ii(0x1018_b5f2, 3); mov(memd_a32[ss, ebp + 0x1c], edx);     /* mov [ebp+0x1c], edx */
        l_0x1018_b5f5:
            ii(0x1018_b5f5, 3); mov(ebx, memd_a32[ss, ebp + 0x8]);      /* mov ebx, [ebp+0x8] */
            ii(0x1018_b5f8, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1018_b5fa, 2); if(jzd(0x1018_b613, 0x17)) goto l_0x1018_b613; /* jz 0x1018b613 */
            ii(0x1018_b5fc, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1018_b5ff, 6); calld_abs(memd_a32[ds, 0x101b_e8b0]);   /* call dword [0x101be8b0] */ /* Вызов '0x1018_b5b0'. */
            ii(0x1018_b605, 3); mov(memd_a32[ss, ebp + 0x20], eax);     /* mov [ebp+0x20], eax */
            ii(0x1018_b608, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_b60a, 2); if(jnzd(0x1018_b616, 0xa)) goto l_0x1018_b616; /* jnz 0x1018b616 */
            ii(0x1018_b60c, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1018_b611, 2); jmpd(0x1018_b616, 0x3); goto l_0x1018_b616; /* jmp 0x1018b616 */
        l_0x1018_b613:
            ii(0x1018_b613, 3); mov(memd_a32[ss, ebp + 0x20], ebx);     /* mov [ebp+0x20], ebx */
        l_0x1018_b616:
            ii(0x1018_b616, 3); cmp(edx, -0x1 /* 0xff */);              /* cmp edx, 0xffffffff */
            ii(0x1018_b619, 2); if(jzd(0x1018_b622, 0x7)) goto l_0x1018_b622; /* jz 0x1018b622 */
            ii(0x1018_b61b, 7); mov(memd_a32[ss, ebp + 0], 0xfeba_feba); /* mov dword [ebp], 0xfebafeba */
        l_0x1018_b622:
            ii(0x1018_b622, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_b624, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_b625, 1); popd(edi);                              /* pop edi */
            ii(0x1018_b626, 1); popd(esi);                              /* pop esi */
            ii(0x1018_b627, 1); retd(); return;                         /* ret */
        }
    }
}
