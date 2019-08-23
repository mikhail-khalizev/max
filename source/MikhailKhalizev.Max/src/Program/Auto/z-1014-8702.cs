using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_8702-4bdf3976")]
        public void Method_1014_8702()
        {
            ii(0x1014_8702, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_8707, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d646); /* call 0x10165d52 */
            ii(0x1014_870c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_870d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_870e, 1); pushd(edx);                             /* push edx */
            ii(0x1014_870f, 1); pushd(esi);                             /* push esi */
            ii(0x1014_8710, 1); pushd(edi);                             /* push edi */
            ii(0x1014_8711, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_8712, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_8714, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_871a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_871d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8720, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1014_8723, 5); calld(0x1007_6574, -0xd_21b4);          /* call 0x10076574 */
            ii(0x1014_8728, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1014_872b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_8730, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_8732, 2); if(jled(0x1014_8744, 0x10)) goto l_0x1014_8744; /* jle 0x10148744 */
            ii(0x1014_8734, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8737, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1014_873a, 5); calld(0x1007_6574, -0xd_21cb);          /* call 0x10076574 */
            ii(0x1014_873f, 5); calld(0x1014_f5c1, 0x6e7d);             /* call 0x1014f5c1 */
        l_0x1014_8744:
            ii(0x1014_8744, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_8746, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_8747, 1); popd(edi);                              /* pop edi */
            ii(0x1014_8748, 1); popd(esi);                              /* pop esi */
            ii(0x1014_8749, 1); popd(edx);                              /* pop edx */
            ii(0x1014_874a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_874b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_874c, 1); retd();                                 /* ret */
        }
    }
}
