using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_e160-1e3f0db5")]
        public void Method_1012_e160()
        {
            ii(0x1012_e160, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_e165, 5); calld(Definitions.sys_check_available_stack_size, 0x3_7be8); /* call 0x10165d52 */
            ii(0x1012_e16a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_e16b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_e16c, 1); pushd(edx);                             /* push edx */
            ii(0x1012_e16d, 1); pushd(esi);                             /* push esi */
            ii(0x1012_e16e, 1); pushd(edi);                             /* push edi */
            ii(0x1012_e16f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_e170, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_e172, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_e178, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_e17b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_e17e, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_e181, 5); calld(Definitions.my_1_get_count, -0x8_2cae); /* call 0x100ab4d8 */
            ii(0x1012_e186, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1012_e189:
            ii(0x1012_e189, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1012_e18c, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1012_e191, 2); if(jzd(0x1012_e1bc, 0x29)) goto l_0x1012_e1bc; /* jz 0x1012e1bc */
            ii(0x1012_e193, 5); mov(ebx, 0x101c_37bc);                  /* mov ebx, 0x101c37bc */
            ii(0x1012_e198, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1012_e19c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_e19f, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_e1a2, 5); calld(0x100e_8634, -0x4_5b73);          /* call 0x100e8634 */
            ii(0x1012_e1a7, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1012_e1a9, 5); calld(0x1007_6d98, -0xb_7416);          /* call 0x10076d98 */
            ii(0x1012_e1ae, 2); test(al, al);                           /* test al, al */
            ii(0x1012_e1b0, 2); if(jzd(0x1012_e1ba, 0x8)) goto l_0x1012_e1ba; /* jz 0x1012e1ba */
            ii(0x1012_e1b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e1b5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_e1b8, 2); jmpd(0x1012_e1c3, 0x9); goto l_0x1012_e1c3; /* jmp 0x1012e1c3 */
        l_0x1012_e1ba:
            ii(0x1012_e1ba, 2); jmpd(0x1012_e189, -0x33); goto l_0x1012_e189; /* jmp 0x1012e189 */
        l_0x1012_e1bc:
            ii(0x1012_e1bc, 7); mov(memd_a32[ss, ebp - 0xc], 0xffff_ffff); /* mov dword [ebp-0xc], 0xffffffff */
        l_0x1012_e1c3:
            ii(0x1012_e1c3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_e1c6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_e1c8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_e1c9, 1); popd(edi);                              /* pop edi */
            ii(0x1012_e1ca, 1); popd(esi);                              /* pop esi */
            ii(0x1012_e1cb, 1); popd(edx);                              /* pop edx */
            ii(0x1012_e1cc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_e1cd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_e1ce, 1); retd();                                 /* ret */
        }
    }
}
