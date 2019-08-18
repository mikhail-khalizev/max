using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1a547df8-56a7-4b09-bd0c-6d452f7b473c")]
        public void Method_1015_90fc()
        {
            ii(0x1015_90fc, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1015_9101, 5); calld(Definitions.sys_check_available_stack_size, 0xcc4c); /* call 0x10165d52 */
            ii(0x1015_9106, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_9107, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_9108, 1); pushd(esi);                             /* push esi */
            ii(0x1015_9109, 1); pushd(edi);                             /* push edi */
            ii(0x1015_910a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_910b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_910d, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1015_9113, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_9116, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_9119, 5); mov(eax, 0x1015_8fc2);                  /* mov eax, 0x10158fc2 */
            ii(0x1015_911e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_911f, 7); mov(memd_a32[ss, ebp - 0x1c], 0x31);    /* mov dword [ebp-0x1c], 0x31 */
            ii(0x1015_9126, 5); mov(eax, StringDefinitions.Place);      /* mov eax, 0x101b2592 */
            ii(0x1015_912b, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_912e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_9131, 5); calld(0x1008_aa4c, -0xc_e6ea);          /* call 0x1008aa4c */
            ii(0x1015_9136, 2); cmp(al, 0x2);                           /* cmp al, 0x2 */
            ii(0x1015_9138, 2); if(jnzd(0x1015_9140, 0x6)) goto l_0x1015_9140; /* jnz 0x10159140 */
            ii(0x1015_913a, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_913e, 2); jmpd(0x1015_9144, 0x4); goto l_0x1015_9144; /* jmp 0x10159144 */
        l_0x1015_9140:
            ii(0x1015_9140, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1015_9144:
            ii(0x1015_9144, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9146, 3); mov(dl, memb_a32[ss, ebp - 0x10]);      /* mov dl, [ebp-0x10] */
            ii(0x1015_9149, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_914c, 3); mov(ecx, memd_a32[ss, ebp - 0x1c]);     /* mov ecx, [ebp-0x1c] */
            ii(0x1015_914f, 3); mov(ebx, memd_a32[ss, ebp - 0x18]);     /* mov ebx, [ebp-0x18] */
            ii(0x1015_9152, 5); calld(0x1015_7ccf, -0x1488);            /* call 0x10157ccf */
            ii(0x1015_9157, 5); mov(eax, 0x1015_905b);                  /* mov eax, 0x1015905b */
            ii(0x1015_915c, 1); pushd(eax);                             /* push eax */
            ii(0x1015_915d, 7); mov(memd_a32[ss, ebp - 0x20], 0x30);    /* mov dword [ebp-0x20], 0x30 */
            ii(0x1015_9164, 5); mov(eax, StringDefinitions.Remove2);    /* mov eax, 0x101b2598 */
            ii(0x1015_9169, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_916c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_916f, 5); calld(0x1008_aa4c, -0xc_e728);          /* call 0x1008aa4c */
            ii(0x1015_9174, 2); cmp(al, 0x1);                           /* cmp al, 0x1 */
            ii(0x1015_9176, 2); if(jnzd(0x1015_917e, 0x6)) goto l_0x1015_917e; /* jnz 0x1015917e */
            ii(0x1015_9178, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_917c, 2); jmpd(0x1015_9182, 0x4); goto l_0x1015_9182; /* jmp 0x10159182 */
        l_0x1015_917e:
            ii(0x1015_917e, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_9182:
            ii(0x1015_9182, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9184, 3); mov(dl, memb_a32[ss, ebp - 0xc]);       /* mov dl, [ebp-0xc] */
            ii(0x1015_9187, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_918a, 3); mov(ecx, memd_a32[ss, ebp - 0x20]);     /* mov ecx, [ebp-0x20] */
            ii(0x1015_918d, 3); mov(ebx, memd_a32[ss, ebp - 0x14]);     /* mov ebx, [ebp-0x14] */
            ii(0x1015_9190, 5); calld(0x1015_7ccf, -0x14c6);            /* call 0x10157ccf */
            ii(0x1015_9195, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_9198, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_919b, 5); calld(0x1015_8bbb, -0x5e5);             /* call 0x10158bbb */
            ii(0x1015_91a0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_91a2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_91a3, 1); popd(edi);                              /* pop edi */
            ii(0x1015_91a4, 1); popd(esi);                              /* pop esi */
            ii(0x1015_91a5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_91a6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_91a7, 1); retd(); return;                         /* ret */
        }
    }
}
