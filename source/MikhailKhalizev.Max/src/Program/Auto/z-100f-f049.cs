using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("184f4152-5a03-4770-93d2-61a0b99d7e7b")]
        public void Method_100f_f049()
        {
            ii(0x100f_f049, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100f_f04e, 5); calld(Definitions.sys_check_available_stack_size, 0x6_6cff); /* call 0x10165d52 */
            ii(0x100f_f053, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_f054, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_f055, 1); pushd(edx);                             /* push edx */
            ii(0x100f_f056, 1); pushd(esi);                             /* push esi */
            ii(0x100f_f057, 1); pushd(edi);                             /* push edi */
            ii(0x100f_f058, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_f059, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_f05b, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_f061, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_f064, 5); calld(0x100f_ef80, -0xe9);              /* call 0x100fef80 */
            ii(0x100f_f069, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100f_f06d, 2); if(jzd(0x100f_f0b1, 0x42)) goto l_0x100f_f0b1; /* jz 0x100ff0b1 */
            ii(0x100f_f06f, 5); calld(0x100f_ef80, -0xf4);              /* call 0x100fef80 */
            ii(0x100f_f074, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_f077, 7); mov(memd_a32[ss, ebp - 0x10], 0x1);     /* mov dword [ebp-0x10], 0x1 */
            ii(0x100f_f07e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_f081, 1); inc(eax);                               /* inc eax */
            ii(0x100f_f082, 4); imul(eax, memd_a32[ss, ebp - 0x4]);     /* imul eax, [ebp-0x4] */
            ii(0x100f_f086, 5); add(eax, 0x443);                        /* add eax, 0x443 */
            ii(0x100f_f08b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_f08e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_f091, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100f_f094, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_f097, 5); calld(0x100d_5470, -0x2_9c2c);          /* call 0x100d5470 */
            ii(0x100f_f09c, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_f09f, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100f_f0a3, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100f_f0a7, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_f0ac, 5); calld(0x1013_daea, 0x3_ea39);           /* call 0x1013daea */
        l_0x100f_f0b1:
            ii(0x100f_f0b1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_f0b3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_f0b4, 1); popd(edi);                              /* pop edi */
            ii(0x100f_f0b5, 1); popd(esi);                              /* pop esi */
            ii(0x100f_f0b6, 1); popd(edx);                              /* pop edx */
            ii(0x100f_f0b7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_f0b8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_f0b9, 1); retd(); return;                         /* ret */
        }
    }
}
