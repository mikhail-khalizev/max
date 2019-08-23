using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_7853-9d4fb0e")]
        public void Method_1010_7853()
        {
            ii(0x1010_7853, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x1010_7858, 5); calld(Definitions.sys_check_available_stack_size, 0x5_e4f5); /* call 0x10165d52 */
            ii(0x1010_785d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_785e, 1); pushd(esi);                             /* push esi */
            ii(0x1010_785f, 1); pushd(edi);                             /* push edi */
            ii(0x1010_7860, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_7861, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_7863, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1010_7869, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_786c, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1010_786f, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1010_7872, 5); mov(eax, 0xe);                          /* mov eax, 0xe */
            ii(0x1010_7877, 5); calld(0x100e_4bdf, -0x2_2c9d);          /* call 0x100e4bdf */
            ii(0x1010_787c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_787f, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1010_7884, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_7887, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_788a, 5); calld(Definitions.sys_memcpy, 0x5_e5bc); /* call 0x10165e4b */
            ii(0x1010_788f, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_7894, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_7897, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_789a, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1010_789d, 5); calld(Definitions.sys_memcpy, 0x5_e5a9); /* call 0x10165e4b */
            ii(0x1010_78a2, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1010_78a7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_78a9, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1010_78ac, 5); calld(Definitions.sys_memset, 0x5_e52f); /* call 0x10165de0 */
            ii(0x1010_78b1, 7); mov(memd_a32[ss, ebp - 0x34], 0x2);     /* mov dword [ebp-0x34], 0x2 */
            ii(0x1010_78b8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_78bb, 3); shr(eax, 0x4);                          /* shr eax, 0x4 */
            ii(0x1010_78be, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1010_78c3, 4); mov(memw_a32[ss, ebp - 0x22], ax);      /* mov [ebp-0x22], ax */
            ii(0x1010_78c7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_78ca, 3); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x1010_78cd, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1010_78d0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_78d3, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1010_78d6, 3); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x1010_78d9, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1010_78dc, 3); lea(edx, ebp - 0x44);                   /* lea edx, [ebp-0x44] */
            ii(0x1010_78df, 5); mov(eax, 0x7a);                         /* mov eax, 0x7a */
            ii(0x1010_78e4, 5); calld(0x100e_44ba, -0x2_342f);          /* call 0x100e44ba */
            ii(0x1010_78e9, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_78ee, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_78f1, 3); add(edx, 0xa);                          /* add edx, 0xa */
            ii(0x1010_78f4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_78f7, 5); calld(Definitions.sys_memcpy, 0x5_e54f); /* call 0x10165e4b */
            ii(0x1010_78fc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_78fe, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_78ff, 1); popd(edi);                              /* pop edi */
            ii(0x1010_7900, 1); popd(esi);                              /* pop esi */
            ii(0x1010_7901, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_7902, 1); retd();                                 /* ret */
        }
    }
}
