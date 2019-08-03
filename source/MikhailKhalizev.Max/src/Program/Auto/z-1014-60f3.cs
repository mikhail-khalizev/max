using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("764e715d-c03a-444f-9bd4-733998d2c23a")]
        public void Method_1014_60f3()
        {
            ii(0x1014_60f3, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1014_60f8, 5); calld(Definitions.sys_check_available_stack_size, 0x1fc55); /* call 0x10165d52 */
            ii(0x1014_60fd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_60fe, 1); pushd(esi);                             /* push esi */
            ii(0x1014_60ff, 1); pushd(edi);                             /* push edi */
            ii(0x1014_6100, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_6101, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_6103, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1014_6109, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_610c, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_610f, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_6112, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x1014_6116, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_6119, 5); calld(Definitions.my_string_ctor, -0x4636); /* call 0x10141ae8 */
            ii(0x1014_611e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_6121, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1014_6125, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1014_6128, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1014_612b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_612e, 5); calld(0x1014_630a, 0x1d7);              /* call 0x1014630a */
            ii(0x1014_6133, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6135, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_6138, 5); calld(0x1013_ad71, -0xb3cc);            /* call 0x1013ad71 */
            ii(0x1014_613d, 2); test(al, al);                           /* test al, al */
            ii(0x1014_613f, 2); if(jzd(0x1014_616f, 0x2e)) goto l_0x1014_616f; /* jz 0x1014616f */
            ii(0x1014_6141, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_6144, 5); calld(0x100e_0760, -0x659e9);           /* call 0x100e0760 */
            ii(0x1014_6149, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_614c, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_614f, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1014_6152, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1014_6155, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_6158, 3); calld_abs(memd_a32[ds, ebx + 0x8]);     /* call dword [ebx+0x8] */
            ii(0x1014_615b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_615d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_6160, 5); calld(0x1014_2246, -0x3f1f);            /* call 0x10142246 */
            ii(0x1014_6165, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6167, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_616a, 5); calld(Definitions.my_string_dtor, -0x4645); /* call 0x10141b2a */
        l_0x1014_616f:
            ii(0x1014_616f, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1014_6172, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_6175, 5); calld(Definitions.my_string_ctor_string, -0x46d4); /* call 0x10141aa6 */
            ii(0x1014_617a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_617c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_617f, 5); calld(0x100e_03bc, -0x65dc8);           /* call 0x100e03bc */
            ii(0x1014_6184, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6186, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_6189, 5); calld(Definitions.my_string_dtor, -0x4664); /* call 0x10141b2a */
            ii(0x1014_618e, 2); jmpd(0x1014_61a4, 0x14); goto l_0x1014_61a4; /* jmp 0x101461a4 */
        //  ii(0x1014_6190, 20); Недостижимый код.
l_0x1014_61a4:
            ii(0x1014_61a4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_61a7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_61a9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_61aa, 1); popd(edi);                              /* pop edi */
            ii(0x1014_61ab, 1); popd(esi);                              /* pop esi */
            ii(0x1014_61ac, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_61ad, 1); retd(); return;                         /* ret */
        }
    }
}
