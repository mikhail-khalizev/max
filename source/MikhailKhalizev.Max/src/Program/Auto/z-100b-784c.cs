using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3e13a83a-e27e-4081-a5d1-65beb7670445")]
        public void Method_100b_784c()
        {
            ii(0x100b_784c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_7851, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e4fc); /* call 0x10165d52 */
            ii(0x100b_7856, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7857, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7858, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7859, 1); pushd(edi);                             /* push edi */
            ii(0x100b_785a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_785b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_785d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_7863, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7866, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_7869, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100b_7870, 2); if(jzd(0x100b_7886, 0x14)) goto l_0x100b_7886; /* jz 0x100b7886 */
            ii(0x100b_7872, 5); mov(edx, 0x101b_50f8);                  /* mov edx, 0x101b50f8 */
            ii(0x100b_7877, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_787a, 5); calld(Definitions.sys_call_dtor_arr, 0xa_e739); /* call 0x10165fb8 */
            ii(0x100b_787f, 5); calld(Definitions.sys_delete_arr, 0xa_e754); /* call 0x10165fd8 */
            ii(0x100b_7884, 2); jmpd(0x100b_78cd, 0x47); goto l_0x100b_78cd; /* jmp 0x100b78cd */
        l_0x100b_7886:
            ii(0x100b_7886, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_7888, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_788b, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_788e, 5); calld(0x1007_5f2c, -0x4_1967);          /* call 0x10075f2c */
            ii(0x100b_7893, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x100b_7896, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7899, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_789b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_789e, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_78a1, 5); calld(0x1007_5f2c, -0x4_197a);          /* call 0x10075f2c */
            ii(0x100b_78a6, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100b_78a9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_78ac, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_78b1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_78b4, 5); calld(0x100a_284c, -0x1_506d);          /* call 0x100a284c */
            ii(0x100b_78b9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_78bc, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100b_78c3, 2); if(jzd(0x100b_78cd, 0x8)) goto l_0x100b_78cd; /* jz 0x100b78cd */
            ii(0x100b_78c5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_78c8, 5); calld(Definitions.sys_delete, 0xa_e697); /* call 0x10165f64 */
        l_0x100b_78cd:
            ii(0x100b_78cd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_78d0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_78d3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_78d6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_78d8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_78d9, 1); popd(edi);                              /* pop edi */
            ii(0x100b_78da, 1); popd(esi);                              /* pop esi */
            ii(0x100b_78db, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_78dc, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_78dd, 1); retd(); return;                         /* ret */
        }
    }
}