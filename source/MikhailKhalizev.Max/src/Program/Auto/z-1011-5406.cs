using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7b139ff9-5b14-4bca-b8ca-224b959665a3")]
        public void Method_1011_5406()
        {
            ii(0x1011_5406, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_540b, 5); calld(Definitions.sys_check_available_stack_size, 0x5_0942); /* call 0x10165d52 */
            ii(0x1011_5410, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_5411, 1); pushd(esi);                             /* push esi */
            ii(0x1011_5412, 1); pushd(edi);                             /* push edi */
            ii(0x1011_5413, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_5414, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5416, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_541c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1011_541f, 1); pushd(eax);                             /* push eax */
            ii(0x1011_5420, 3); mov(edx, memd_a32[ss, ebp + 0x1c]);     /* mov edx, [ebp+0x1c] */
            ii(0x1011_5423, 2); mov(ebx, ds);                           /* mov ebx, ds */
            ii(0x1011_5425, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1011_5428, 3); mov(esi, memd_a32[ss, ebp + 0x14]);     /* mov esi, [ebp+0x14] */
            ii(0x1011_542b, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1011_542d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_542f, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1011_5431, 5); calld(/* sys */ 0x1017_9414, 0x6_3fde); /* call 0x10179414 */
            ii(0x1011_5436, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_5439, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1011_543d, 2); if(jnzd(0x1011_5447, 0x8)) goto l_0x1011_5447; /* jnz 0x10115447 */
            ii(0x1011_543f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_5442, 3); cmp(eax, memd_a32[ss, ebp + 0x1c]);     /* cmp eax, [ebp+0x1c] */
            ii(0x1011_5445, 2); if(jzd(0x1011_5450, 0x9)) goto l_0x1011_5450; /* jz 0x10115450 */
        l_0x1011_5447:
            ii(0x1011_5447, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_544e, 2); jmpd(0x1011_5457, 0x7); goto l_0x1011_5457; /* jmp 0x10115457 */
        l_0x1011_5450:
            ii(0x1011_5450, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
        l_0x1011_5457:
            ii(0x1011_5457, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_545a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_545c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_545d, 1); popd(edi);                              /* pop edi */
            ii(0x1011_545e, 1); popd(esi);                              /* pop esi */
            ii(0x1011_545f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_5460, 1); retd(); return;                         /* ret */
        }
    }
}
