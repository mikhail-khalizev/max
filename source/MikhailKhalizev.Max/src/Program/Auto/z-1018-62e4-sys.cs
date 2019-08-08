using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eae51ab1-bceb-4c75-9622-49fe87185cbd")]
        public void /* sys */ Method_1018_62e4()
        {
            ii(0x1018_62e4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_62e5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_62e6, 1); pushd(edx);                             /* push edx */
            ii(0x1018_62e7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_62e8, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1018_62ed, 5); mov(eax, memd_a32[ds, 0x101b_e85c]);    /* mov eax, [0x101be85c] */
            ii(0x1018_62f2, 6); mov(memd_a32[ds, 0x101b_e85c], edx);    /* mov [0x101be85c], edx */
            ii(0x1018_62f8, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1018_62fb, 2); if(jbd(0x1018_6304, 0x7)) goto l_0x1018_6304; /* jb 0x10186304 */
            ii(0x1018_62fd, 2); if(jbed(0x1018_6343, 0x44)) goto l_0x1018_6343; /* jbe 0x10186343 */
            ii(0x1018_62ff, 5); jmpd(0x1018_6392, 0x8e); goto l_0x1018_6392; /* jmp 0x10186392 */
        l_0x1018_6304:
            ii(0x1018_6304, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_6306, 6); if(jnzd(0x1018_6392, 0x86)) goto l_0x1018_6392; /* jnz 0x10186392 */
            ii(0x1018_630c, 5); calld(/* sys */ 0x1018_66ac, 0x39b);    /* call 0x101866ac */
            ii(0x1018_6311, 5); mov(eax, memd_a32[ds, 0x101b_e878]);    /* mov eax, [0x101be878] */
            ii(0x1018_6316, 5); calld(Definitions.sys_fclose_internal, -0x1_53a3); /* call 0x10170f78 */
            ii(0x1018_631b, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1018_631d, 5); mov(eax, memd_a32[ds, 0x101b_e854]);    /* mov eax, [0x101be854] */
            ii(0x1018_6322, 6); mov(memd_a32[ds, 0x101b_e878], ebp);    /* mov [0x101be878], ebp */
            ii(0x1018_6328, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_632a, 2); if(jzd(0x1018_6392, 0x66)) goto l_0x1018_6392; /* jz 0x10186392 */
            ii(0x1018_632c, 5); calld(/* sys */ 0x1018_668c, 0x35b);    /* call 0x1018668c */
            ii(0x1018_6331, 5); mov(eax, memd_a32[ds, 0x101b_e854]);    /* mov eax, [0x101be854] */
            ii(0x1018_6336, 5); calld(Definitions.sys_free_internal, -0x3ee7); /* call 0x10182454 */
            ii(0x1018_633b, 6); mov(memd_a32[ds, 0x101b_e854], ebp);    /* mov [0x101be854], ebp */
            ii(0x1018_6341, 2); jmpd(0x1018_6392, 0x4f); goto l_0x1018_6392; /* jmp 0x10186392 */
        l_0x1018_6343:
            ii(0x1018_6343, 5); mov(eax, memd_a32[ds, 0x101b_e878]);    /* mov eax, [0x101be878] */
            ii(0x1018_6348, 5); calld(Definitions.sys_fclose_internal, -0x1_53d5); /* call 0x10170f78 */
            ii(0x1018_634d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_634f, 6); mov(ecx, memd_a32[ds, 0x101b_e854]);    /* mov ecx, [0x101be854] */
            ii(0x1018_6355, 6); mov(memd_a32[ds, 0x101b_e878], ebx);    /* mov [0x101be878], ebx */
            ii(0x1018_635b, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1018_635d, 2); if(jzd(0x1018_6374, 0x15)) goto l_0x1018_6374; /* jz 0x10186374 */
            ii(0x1018_635f, 5); calld(/* sys */ 0x1018_668c, 0x328);    /* call 0x1018668c */
            ii(0x1018_6364, 5); mov(eax, memd_a32[ds, 0x101b_e854]);    /* mov eax, [0x101be854] */
            ii(0x1018_6369, 5); calld(Definitions.sys_free_internal, -0x3f1a); /* call 0x10182454 */
            ii(0x1018_636e, 6); mov(memd_a32[ds, 0x101b_e854], ebx);    /* mov [0x101be854], ebx */
        l_0x1018_6374:
            ii(0x1018_6374, 5); mov(eax, memd_a32[ds, 0x101b_e888]);    /* mov eax, [0x101be888] */
            ii(0x1018_6379, 5); calld(/* sys */ 0x1017_2cb8, -0x1_36c6); /* call 0x10172cb8 */
            ii(0x1018_637e, 7); cmp(memd_a32[ds, 0x101b_e880], 0);      /* cmp dword [0x101be880], 0x0 */
            ii(0x1018_6385, 2); if(jzd(0x1018_6392, 0xb)) goto l_0x1018_6392; /* jz 0x10186392 */
            ii(0x1018_6387, 5); mov(eax, memd_a32[ds, 0x101b_e86c]);    /* mov eax, [0x101be86c] */
            ii(0x1018_638c, 6); calld_abs(memd_a32[ds, 0x101b_e880]);   /* call dword [0x101be880] */
        l_0x1018_6392:
            ii(0x1018_6392, 5); calld(/* sys */ 0x1017_2bf0, -0x1_37a7); /* call 0x10172bf0 */
            ii(0x1018_6397, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1018_639c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_639d, 1); popd(edx);                              /* pop edx */
            ii(0x1018_639e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_639f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_63a0, 1); retd(); return;                         /* ret */
        }
    }
}
