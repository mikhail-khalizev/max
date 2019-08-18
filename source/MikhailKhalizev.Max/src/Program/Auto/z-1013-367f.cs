using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d92f4e23-5b1a-4573-95bd-d3d99b47914a")]
        public void Method_1013_367f()
        {
            ii(0x1013_367f, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_3684, 5); calld(Definitions.sys_check_available_stack_size, 0x3_26c9); /* call 0x10165d52 */
            ii(0x1013_3689, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_368a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_368b, 1); pushd(edx);                             /* push edx */
            ii(0x1013_368c, 1); pushd(esi);                             /* push esi */
            ii(0x1013_368d, 1); pushd(edi);                             /* push edi */
            ii(0x1013_368e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_368f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_3691, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_3697, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_369a, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1013_369e, 2); jmpd(0x1013_36a3, 0x3); goto l_0x1013_36a3; /* jmp 0x101336a3 */
        l_0x1013_36a0:
            ii(0x1013_36a0, 3); inc(memb_a32[ss, ebp - 0x8]);           /* inc byte [ebp-0x8] */
        l_0x1013_36a3:
            ii(0x1013_36a3, 4); cmp(memb_a32[ss, ebp - 0x8], 0x8);      /* cmp byte [ebp-0x8], 0x8 */
            ii(0x1013_36a7, 6); if(jged(0x1013_373a, 0x8d)) goto l_0x1013_373a; /* jge 0x1013373a */
            ii(0x1013_36ad, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_36b1, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_36b7, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1013_36bc, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_36be, 4); movsx(eax, memb_a32[ss, ebp - 0x8]);    /* movsx eax, byte [ebp-0x8] */
            ii(0x1013_36c2, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1013_36c5, 6); add(edx, 0x88);                         /* add edx, 0x88 */
            ii(0x1013_36cb, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_36cd, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1013_36d0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_36d3, 4); cmp(memd_a32[ds, eax + 0x8], 0);        /* cmp dword [eax+0x8], 0x0 */
            ii(0x1013_36d7, 2); if(jzd(0x1013_3735, 0x5c)) goto l_0x1013_3735; /* jz 0x10133735 */
            ii(0x1013_36d9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_36dc, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1013_36df, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_36e2, 3); sub(memd_a32[ds, eax + 0x4], edx);      /* sub [eax+0x4], edx */
            ii(0x1013_36e5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_36e8, 4); cmp(memd_a32[ds, eax + 0x4], 0);        /* cmp dword [eax+0x4], 0x0 */
            ii(0x1013_36ec, 2); if(jgd(0x1013_3735, 0x47)) goto l_0x1013_3735; /* jg 0x10133735 */
            ii(0x1013_36ee, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_36f1, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
            ii(0x1013_36f8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_36fb, 2); inc(memd_a32[ds, eax]);                 /* inc dword [eax] */
            ii(0x1013_36fd, 4); movsx(edx, memb_a32[ss, ebp - 0x8]);    /* movsx edx, byte [ebp-0x8] */
            ii(0x1013_3701, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_3705, 5); calld(0x1013_3330, -0x3da);             /* call 0x10133330 */
            ii(0x1013_370a, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1013_370e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_3710, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1013_3715, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_3717, 2); if(jnzd(0x1013_3735, 0x1c)) goto l_0x1013_3735; /* jnz 0x10133735 */
            ii(0x1013_3719, 5); calld(0x100d_5470, -0x5_e2ae);          /* call 0x100d5470 */
            ii(0x1013_371e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1013_3721, 5); mov(ebx, 0x43a);                        /* mov ebx, 0x43a */
            ii(0x1013_3726, 5); mov(edx, 0x439);                        /* mov edx, 0x439 */
            ii(0x1013_372b, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1013_3730, 5); calld(0x1013_daea, 0xa3b5);             /* call 0x1013daea */
        l_0x1013_3735:
            ii(0x1013_3735, 5); jmpd(0x1013_36a0, -0x9a); goto l_0x1013_36a0; /* jmp 0x101336a0 */
        l_0x1013_373a:
            ii(0x1013_373a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_373c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_373d, 1); popd(edi);                              /* pop edi */
            ii(0x1013_373e, 1); popd(esi);                              /* pop esi */
            ii(0x1013_373f, 1); popd(edx);                              /* pop edx */
            ii(0x1013_3740, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_3741, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_3742, 1); retd(); return;                         /* ret */
        }
    }
}
