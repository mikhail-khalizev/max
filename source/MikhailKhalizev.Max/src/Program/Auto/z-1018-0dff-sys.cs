using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_0dff-7f27f8fc")]
        public void /* sys */ Method_1018_0dff()
        {
            ii(0x1018_0dff, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_0e00, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_0e01, 1); pushd(esi);                             /* push esi */
            ii(0x1018_0e02, 1); pushd(edi);                             /* push edi */
            ii(0x1018_0e03, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_0e04, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_0e06, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1018_0e0c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1018_0e0f, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1018_0e12, 4); cmp(memd_a32[ss, ebp - 0x8], 0x20);     /* cmp dword [ebp-0x8], 0x20 */
            ii(0x1018_0e16, 2); if(jaed(0x1018_0e48, 0x30)) goto l_0x1018_0e48; /* jae 0x10180e48 */
            ii(0x1018_0e18, 7); imul(edx, memd_a32[ss, ebp - 0xc], 0xc0); /* imul edx, [ebp-0xc], 0xc0 */
            ii(0x1018_0e1f, 4); imul(eax, memd_a32[ss, ebp - 0x8], 0x6); /* imul eax, [ebp-0x8], 0x6 */
            ii(0x1018_0e23, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0e25, 7); lgs(eax, ds, eax + 0x1020_b718);        /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_0e2c, 5); movsx(eax, memw_a32[gs, eax + 0x30]);   /* movsx eax, word [gs:eax+0x30] */
            ii(0x1018_0e31, 3); test(ah, 0x80);                         /* test ah, 0x80 */
            ii(0x1018_0e34, 2); if(jnzd(0x1018_0e3f, 0x9)) goto l_0x1018_0e3f; /* jnz 0x10180e3f */
            ii(0x1018_0e36, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
            ii(0x1018_0e3d, 2); jmpd(0x1018_0e4f, 0x10); goto l_0x1018_0e4f; /* jmp 0x10180e4f */
        l_0x1018_0e3f:
            ii(0x1018_0e3f, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1018_0e46, 2); jmpd(0x1018_0e4f, 0x7); goto l_0x1018_0e4f; /* jmp 0x10180e4f */
        l_0x1018_0e48:
            ii(0x1018_0e48, 7); mov(memd_a32[ss, ebp - 0x4], 0xa);      /* mov dword [ebp-0x4], 0xa */
        l_0x1018_0e4f:
            ii(0x1018_0e4f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1018_0e52, 1); leaved();                               /* leave */
            ii(0x1018_0e53, 1); popd(edi);                              /* pop edi */
            ii(0x1018_0e54, 1); popd(esi);                              /* pop esi */
            ii(0x1018_0e55, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_0e56, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_0e57, 1); retd();                                 /* ret */
        }
    }
}
